using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MarketingHub.Data;
using MarketingHub.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Authorize(Roles = MarketingHub.Utility.SD.Role_Agency)]
public class MarketingAgencyController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public MarketingAgencyController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // Populate categories helper method
    private async Task PopulateCategories()
    {
        var categories = await _context.Categories.ToListAsync();
        ViewBag.Categories = new SelectList(categories, "CategoryId", "CategoryName");
    }

    public async Task<IActionResult> Index(string search)
    {
        IQueryable<MarketingAgency> allAgencies = _context.MarketingAgency;
        var agencies = _context.MarketingAgency
    .Include(a => a.MarketingAgencyCategories)
       .ThenInclude(mac => mac.Category)
    .Include(a => a.MarketingAgencyContractTypes)
       .ThenInclude(mct => mct.ContractType)
    .ToList();
        if (!string.IsNullOrEmpty(search))
        {
            allAgencies = allAgencies.Where(a => a.Username.ToLower().Contains(search.ToLower()));
        }

        List<MarketingAgency> marketingAgencies = await allAgencies.ToListAsync();
        return View(marketingAgencies);
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return BadRequest();
        }

        MarketingAgency marketingAgency = await _context.MarketingAgency
            .FirstOrDefaultAsync(a => a.MarketingAgencyId == id);
        var agency = _context.MarketingAgency
                     .Include(a => a.Feedbacks) // Include feedbacks
                         .ThenInclude(f => f.Customer) // Include customers of feedbacks
                     .FirstOrDefault(a => a.MarketingAgencyId == id);

        if (marketingAgency == null)
        {
            return NotFound();
        }

        return View(marketingAgency);
    }

    public async Task<IActionResult> ViewLocation(int? id)
    {
        var location = await _context.Locations
            .FirstOrDefaultAsync(a => a.LocationId == id);

        if (location == null)
        {
            return NotFound();
        }

        return View(location);
    }

    public async Task<IActionResult> Requests()
    {
        var userId = _userManager.GetUserId(User);
        var today = DateTime.Today;

        var requests = await _context.Appointments
            .Where(r => r.MarketingAgency.UserId == userId &&
                        ((r.Status == "Accepted" && r.EndDateTime >= today) ||
                         (r.Status == "Pending" && r.StartDateTime > today && r.EndDateTime >= today)))
            .Include(r => r.Customer)
            .ToListAsync();

        return View(requests);
    }


    [HttpPost]
    public IActionResult Approve(int appointmentId)
    {
        var appointment = _context.Appointments.Find(appointmentId);
        if (appointment != null)
        {
            appointment.Status = "Accepted";
            _context.SaveChanges();
        }
        return RedirectToAction("Requests");
    }

    [HttpPost]
    public IActionResult Reject(int appointmentId)
    {
        var appointment = _context.Appointments.Find(appointmentId);
        if (appointment != null)
        {
            appointment.Status = "Rejected";
            _context.SaveChanges();
        }
        return RedirectToAction("Requests");
    }

    public async Task<IActionResult> Profile()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return NotFound();
        }

        var agency = await _context.MarketingAgency
            .Include(a => a.Location)
            .FirstOrDefaultAsync(a => a.UserId == user.Id);

        if (agency == null)
        {
            return NotFound();
        }

        var feedbacks = await _context.Feedbacks
            .Where(f => f.MarketingAgencyId == agency.MarketingAgencyId)
            .Include(f => f.Customer)
            .ToListAsync();

        var today = DateTime.Today;

        // Fetch all appointments for statistics and bar chart
        var allAppointments = await _context.Appointments
            .Where(r => r.MarketingAgency.UserId == user.Id)
            .Include(r => r.Customer)
            .ToListAsync();

        // Fetch filtered appointment requests for the "Profile Requests" tab
        var appointmentRequests = allAppointments
            .Where(r => (r.Status == "Accepted" ||
                         (r.Status == "Pending" && r.StartDateTime > today)) &&
                        r.EndDateTime >= today)
            .ToList();

        // Fetch proposals with status Accepted, Pending, or Rejected
        var proposals = await _context.Proposals
            .Where(r => r.MarketingAgency.UserId == user.Id &&
                        (r.Status == "Accepted" || r.Status == "Pending" || r.Status == "Rejected"))
            .ToListAsync();

        // Calculate appointment statistics
        int acceptedCount = allAppointments.Count(r => r.Status == "Accepted");
        int pendingCount = allAppointments.Count(r => r.Status == "Pending");
        int rejectedCount = allAppointments.Count(r => r.Status == "Rejected");
        int canceledCount = allAppointments.Count(r => r.Status == "Canceled");


        int totalAppointments = allAppointments.Count();

        // Calculate proposal statistics
        int acceptedProposalsCount = proposals.Count(p => p.Status == "Accepted");
        int rejectedProposalsCount = proposals.Count(p => p.Status == "Rejected");
        int pendingProposalsCount = proposals.Count(p => p.Status == "Pending");
        int totalProposals = proposals.Count();

        // Calculate budget statistics for proposals
        double minBudget = proposals.Where(p => p.Status == "Accepted").Select(p => p.MinBudget).DefaultIfEmpty(0).Min();
        double maxBudget = proposals.Where(p => p.Status == "Accepted").Select(p => p.MaxBudget).DefaultIfEmpty(0).Max();
        double avgBudget = proposals.Where(p => p.Status == "Accepted").Select(p => (p.MinBudget + p.MaxBudget) / 2).DefaultIfEmpty(0).Average();

        // Calculate feedback statistics
        int postedFeedbacksCount = await _context.Feedbacks
            .Where(f => f.MarketingAgencyId == agency.MarketingAgencyId)
            .CountAsync();

        int reportsCount = await _context.Reports
         .Where(r => r.MarketingAgencyId == agency.MarketingAgencyId)
         .CountAsync();

        // Pass data to the view
        ViewBag.AppointmentRequests = appointmentRequests; // Filtered requests
        ViewBag.AllAppointments = allAppointments; // All appointments for bar chart
        ViewBag.Proposals = proposals;
        ViewBag.AcceptedCount = acceptedCount;
        ViewBag.PendingCount = pendingCount;
        ViewBag.RejectedCount = rejectedCount;
        ViewBag.CanceledCount = canceledCount;
        ViewBag.TotalAppointments = totalAppointments;
        ViewBag.AcceptedProposalsCount = acceptedProposalsCount;
        ViewBag.RejectedProposalsCount = rejectedProposalsCount;
        ViewBag.PendingProposalsCount = pendingProposalsCount;
        ViewBag.TotalProposals = totalProposals;
        ViewBag.MinBudget = minBudget;
        ViewBag.MaxBudget = maxBudget;
        ViewBag.AvgBudget = avgBudget;
        ViewBag.PostedFeedbacksCount = postedFeedbacksCount;
        ViewBag.ReportsCount = reportsCount;

        return View(agency);
    }



    public async Task<IActionResult> EditProfile(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var marketingAgency = await _context.MarketingAgency.FindAsync(id);
        if (marketingAgency == null)
        {
            return NotFound();
        }

        var locations = await _context.Locations.ToListAsync();
        ViewBag.Locations = new SelectList(locations, "LocationId", "LocationName");
        await PopulateCategories();

        return View(marketingAgency);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditProfile(MarketingAgency marketingAgency)
    {
        marketingAgency.Location.LocationId = (int) marketingAgency.LocationId;
        marketingAgency.Rating= _context.Feedbacks
                .Where(f => f.MarketingAgencyId == marketingAgency.MarketingAgencyId)
                .Average(f => f.Rating);
        if (!ModelState.IsValid)
        {
            var locations = await _context.Locations.ToListAsync();
            ViewBag.Locations = new SelectList(locations, "LocationId", "LocationName");
            await PopulateCategories();
            return View(marketingAgency);
        }

        try
        {
            var user = await _userManager.FindByIdAsync(marketingAgency.UserId);

            if (user != null)
            {
                if (user.Email != marketingAgency.Email)
                {
                    user.Email = marketingAgency.Email;
                    await _userManager.UpdateAsync(user);
                }

                user.UserName = marketingAgency.Username;
                _context.Update(user);
            }

            _context.MarketingAgency.Update(marketingAgency);

            var existingLocation = await _context.Locations.FindAsync(marketingAgency.LocationId);
            if (existingLocation != null)
            {
                existingLocation = marketingAgency.Location;
                _context.Locations.Update(existingLocation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        catch (DbUpdateConcurrencyException)
        {
            return NotFound();
        }
    }

    public async Task<IActionResult> Portfolio(int id)
    {
        ViewBag.MarketingAgencyId = id;
        var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
        return View(posts);
    }

    public async Task<IActionResult> MyPosts(int id)
    {
        ViewBag.MarketingAgencyId = id;
        var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
        return View(posts);
    }

    [HttpPost]
    public async Task<IActionResult> UploadPost(int id, string caption, string videoLink, string pictureLink)
    {
        if (string.IsNullOrEmpty(caption) || string.IsNullOrEmpty(videoLink) || string.IsNullOrEmpty(pictureLink))
        {
            ViewBag.ErrorMessage = "All fields are required.";
            ViewBag.MarketingAgencyId = id;
            var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
            return View("Portfolio", posts);
        }

        var marketingAgency = await _context.MarketingAgency.FindAsync(id);
        if (marketingAgency == null)
        {
            ViewBag.ErrorMessage = "Invalid Marketing Agency ID.";
            ViewBag.MarketingAgencyId = id;
            var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
            return View("Portfolio", posts);
        }

        var post = new Post
        {
            Caption = caption,
            Content = videoLink,
            picContent = pictureLink,
            CreatedAt = DateTime.Now,
            MarketingAgencyId = id
        };

        _context.Posts.Add(post);
        await _context.SaveChangesAsync();

        return RedirectToAction("MyPosts", new { id });
    }

    [HttpPost]
    public async Task<IActionResult> DeletePost(int id)
    {
        var post = await _context.Posts.FindAsync(id);
        if (post == null)
        {
            return NotFound();
        }

        _context.Posts.Remove(post);
        await _context.SaveChangesAsync();

        return RedirectToAction("MyPosts", new { id = post.MarketingAgencyId });
    }

    [HttpPost]
    public async Task<IActionResult> EditPost(int id, string caption, string videoLink, string pictureLink)
    {
        var post = await _context.Posts.FindAsync(id);
        if (post == null)
        {
            ViewBag.ErrorMessage = "Invalid Post ID.";
            var posts = await _context.Posts.ToListAsync();
            return View("Portfolio", posts);
        }

        post.Caption = caption;
        post.Content = videoLink;
        post.picContent = pictureLink;

        _context.Posts.Update(post);
        await _context.SaveChangesAsync();

        return RedirectToAction("MyPosts", new { id = post.MarketingAgencyId });
    }



    public async Task<IActionResult> ProposalsReceived()
    {
        var agencyId = await GetCurrentAgencyId();
        var proposals = await _context.Proposals
        .Include(p => p.Customer)
        .Where(p => p.MarketingAgencyId == agencyId &&
                    (p.Status == "Accepted" || p.Status == "Pending"))
        .ToListAsync();
        return View(proposals);
    }

    public async Task<IActionResult> ProposalDetails(int id)
    {
        var proposal = await _context.Proposals
            .Include(p => p.Customer)
            .FirstOrDefaultAsync(p => p.ProposalId == id);

        if (proposal == null)
        {
            return NotFound();
        }

        return View(proposal);
    }

    [HttpPost]
    public async Task<IActionResult> AcceptProposal(int id, string acceptanceNotes)
    {
        var proposal = await _context.Proposals.FindAsync(id);
        if (proposal != null && proposal.Status == "Pending")
        {
            proposal.Status = "Accepted";
            proposal.AcceptanceNotes = acceptanceNotes;
            _context.Update(proposal);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(ProposalsReceived));
    }

    [HttpPost]
    public async Task<IActionResult> RejectProposal(int id, string rejectionReason)
    {
        var proposal = await _context.Proposals.FindAsync(id);
        if (proposal != null && proposal.Status == "Pending")
        {
            proposal.Status = "Rejected";
            proposal.RejectionReason = rejectionReason;
            _context.Update(proposal);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(ProposalsReceived));
    }

    public async Task<IActionResult> Categories()
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyCategories)
                                    .ThenInclude(mac => mac.Category)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var categories = agency.MarketingAgencyCategories;

        return View(categories);
    }
   
    private async Task<int?> GetCurrentAgencyId()
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
            .FirstOrDefaultAsync(a => a.UserId == userId);

        return agency?.MarketingAgencyId;
    }
    public async Task<IActionResult> AddCategory()
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency.FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        // Fetch categories from the Categories table
        var categories = await _context.Categories
            .Select(c => new SelectListItem
            {
                Value = c.CategoryId.ToString(),
                Text = c.Name
            })
            .ToListAsync();

        if (categories == null || !categories.Any())
        {
            // Handle the case where there are no categories available
            // You can redirect to a different action or display an error message
            return NotFound("No categories available.");
        }

        // Set ViewBag instead of model property
        ViewBag.AvailableCategories = categories;

        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddCategory(MarketingAgencyCategory marketingAgencyCategory)
    {
        // Get the current user's ID
        var userId = _userManager.GetUserId(User);

        // Find the agency associated with the current user
        var agency = await _context.MarketingAgency.FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        // Check if the category already exists for the agency
        var existingCategory = await _context.MarketingAgencyCategory
                                              .FirstOrDefaultAsync(mc => mc.CategoryId == marketingAgencyCategory.CategoryId
                                                                     && mc.MarketingAgencyId == agency.MarketingAgencyId);

        if (existingCategory != null)
        {
            // Category already exists for the agency, add a TempData message and redirect
            TempData["ErrorMessage"] = "Category already exists for the agency.";
            return RedirectToAction(nameof(Categories));
        }

        // If the category doesn't exist, add it
        marketingAgencyCategory.MarketingAgencyId = agency.MarketingAgencyId;

        _context.MarketingAgencyCategory.Add(marketingAgencyCategory);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Categories));
    }

    public async Task<IActionResult> EditCategory(int oldCategoryId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyCategories)
                                        .ThenInclude(ac => ac.Category)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var category = agency.MarketingAgencyCategories.FirstOrDefault(c => c.CategoryId == oldCategoryId);

        if (category == null)
        {
            return NotFound();
        }

        // Fetch categories specific to the agency that are not already associated
        var alreadyAssociatedCategoryIds = agency.MarketingAgencyCategories.Select(ac => ac.CategoryId);
        var availableCategories = await _context.Categories
                                            .Where(c => !alreadyAssociatedCategoryIds.Contains(c.CategoryId))
                                            .ToListAsync();

        // Convert fetched categories to SelectListItem
        var availableCategoriesSelectList = availableCategories.Select(c => new SelectListItem
        {
            Value = c.CategoryId.ToString(),
            Text = c.Name
        }).ToList();

        // Set ViewBag instead of model property
        ViewBag.AvailableCategories = availableCategoriesSelectList;

        return View(category);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditCategory(int oldCategoryId, int newCategoryId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyCategories)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var categoryToRemove = agency.MarketingAgencyCategories.FirstOrDefault(c => c.CategoryId == oldCategoryId);

        if (categoryToRemove == null)
        {
            return NotFound();
        }

        var categoryToAdd = await _context.Categories.FindAsync(newCategoryId);
        if (categoryToAdd == null)
        {
            return NotFound();
        }

        try
        {
            // Remove the existing association
            _context.MarketingAgencyCategory.Remove(categoryToRemove);

            // Add a new association
            var newAssociation = new MarketingAgencyCategory
            {
                MarketingAgencyId = agency.MarketingAgencyId, // Assign the agency id
                CategoryId = newCategoryId
            };
            _context.MarketingAgencyCategory.Add(newAssociation);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Categories));
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, "An error occurred while updating the category.");
        }
    }



    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteCategory(int categoryId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyCategories)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var category = agency.MarketingAgencyCategories.FirstOrDefault(c => c.CategoryId == categoryId);

        if (category == null)
        {
            return NotFound();
        }

        // Remove the category from the agency
        _context.MarketingAgencyCategory.Remove(category);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Categories));
    }
    public async Task<IActionResult> ContractTypes()
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyContractTypes)
                                        .ThenInclude(ac => ac.ContractType)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var contractTypes = agency.MarketingAgencyContractTypes;

        return View(contractTypes);
    }

    public async Task<IActionResult> AddContractType()
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency.FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        // Fetch contract types from the ContractTypes table
        var contractTypes = await _context.ContractTypes
            .Select(ct => new SelectListItem
            {
                Value = ct.ContractTypeId.ToString(),
                Text = ct.Name
            })
            .ToListAsync();

        if (contractTypes == null || !contractTypes.Any())
        {
            // Handle the case where there are no contract types available
            // You can redirect to a different action or display an error message
            return NotFound("No contract types available.");
        }

        // Set ViewBag instead of model property
        ViewBag.AvailableContractTypes = contractTypes;

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddContractType(MarketingAgencyContractType marketingAgencyContractType)
    {
        // Get the current user's ID
        var userId = _userManager.GetUserId(User);

        // Find the agency associated with the current user
        var agency = await _context.MarketingAgency.FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        // Check if the contract type already exists for the agency
        var existingContractType = await _context.MarketingAgencyContractTypes
                                              .FirstOrDefaultAsync(mact => mact.ContractTypeId == marketingAgencyContractType.ContractTypeId
                                                                            && mact.MarketingAgencyId == agency.MarketingAgencyId);

        if (existingContractType != null)
        {
            // Contract type already exists for the agency, add a TempData message and redirect
            TempData["ErrorMessage"] = "Contract type already exists for the agency.";
            return RedirectToAction(nameof(ContractTypes));
        }

        // If the contract type doesn't exist, add it
        marketingAgencyContractType.MarketingAgencyId = agency.MarketingAgencyId;

        _context.MarketingAgencyContractTypes.Add(marketingAgencyContractType);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(ContractTypes));
    }

    public async Task<IActionResult> EditContractType(int oldContractTypeId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyContractTypes)
                                        .ThenInclude(mact => mact.ContractType)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var contractType = agency.MarketingAgencyContractTypes.FirstOrDefault(c => c.ContractTypeId == oldContractTypeId);

        if (contractType == null)
        {
            return NotFound();
        }

        // Fetch contract types specific to the agency that are not already associated
        var alreadyAssociatedContractTypeIds = agency.MarketingAgencyContractTypes.Select(mact => mact.ContractTypeId);
        var availableContractTypes = await _context.ContractTypes
                                            .Where(ct => !alreadyAssociatedContractTypeIds.Contains(ct.ContractTypeId))
                                            .ToListAsync();

        // Convert fetched contract types to SelectListItem
        var availableContractTypesSelectList = availableContractTypes.Select(ct => new SelectListItem
        {
            Value = ct.ContractTypeId.ToString(),
            Text = ct.Name
        }).ToList();

        // Set ViewBag instead of model property
        ViewBag.AvailableContractTypes = availableContractTypesSelectList;

        return View(contractType);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditContractType(int oldContractTypeId, int newContractTypeId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyContractTypes)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var contractTypeToRemove = agency.MarketingAgencyContractTypes.FirstOrDefault(c => c.ContractTypeId == oldContractTypeId);

        if (contractTypeToRemove == null)
        {
            return NotFound();
        }

        var contractTypeToAdd = await _context.ContractTypes.FindAsync(newContractTypeId);
        if (contractTypeToAdd == null)
        {
            return NotFound();
        }

        try
        {
            // Remove the existing association
            _context.MarketingAgencyContractTypes.Remove(contractTypeToRemove);

            // Add a new association
            var newAssociation = new MarketingAgencyContractType
            {
                MarketingAgencyId = agency.MarketingAgencyId, // Assign the agency id
                ContractTypeId = newContractTypeId
            };
            _context.MarketingAgencyContractTypes.Add(newAssociation);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(ContractTypes));
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, "An error occurred while updating the contract type.");
        }
    }
    public async Task<IActionResult> Payments()
    {
        var agencyId = await GetCurrentAgencyId();
        var payments = await _context.Payments
            .Where(p => p.MarketingAgencyId == agencyId) // Adjust according to your agency identity retrieval
            .Include(p => p.Customer)
        .Include(p => p.MarketingAgency)
        .ToListAsync();
        return View(payments);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteContractType(int contractTypeId)
    {
        var userId = _userManager.GetUserId(User);
        var agency = await _context.MarketingAgency
                                    .Include(a => a.MarketingAgencyContractTypes)
                                    .FirstOrDefaultAsync(a => a.UserId == userId);

        if (agency == null)
        {
            return NotFound();
        }

        var contractType = agency.MarketingAgencyContractTypes.FirstOrDefault(c => c.ContractTypeId == contractTypeId);

        if (contractType == null)
        {
            return NotFound();
        }

        // Remove the contract type from the agency
        _context.MarketingAgencyContractTypes.Remove(contractType);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(ContractTypes));
    }

    // Method to view reports for the logged-in marketing agency
    public async Task<IActionResult> ViewReports()
    {
        var userId = _userManager.GetUserId(User);
        var marketingAgency = await _context.MarketingAgency
            .Include(ma => ma.Reports)
            .ThenInclude(r => r.Customer)
            .FirstOrDefaultAsync(ma => ma.UserId == userId);

        if (marketingAgency == null)
        {
            return NotFound();
        }

        return View(marketingAgency.Reports);
    }

    // Method to refute a report
    [HttpGet]
    public async Task<IActionResult> RefuteReport(int reportId)
    {
        var report = await _context.Reports.FindAsync(reportId);
       

        return View(report);
    }

    [HttpPost]
    public async Task<IActionResult> RefuteReport(Report report)
    {
        var existingReport = await _context.Reports.FindAsync(report.ReportId);
        

        
            existingReport.RefutationDetails = report.RefutationDetails;
            existingReport.RefutedAt = DateTime.Now;
            _context.Update(existingReport);
            await _context.SaveChangesAsync();
            TempData["Notification"] = "Report refuted successfully.";
            return RedirectToAction("ViewReports");
        
    }

}
