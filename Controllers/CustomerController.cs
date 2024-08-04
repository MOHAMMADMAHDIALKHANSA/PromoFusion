using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketingHub.Data;
using MarketingHub.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using MarketingHub.Services;
[Authorize(Roles = MarketingHub.Utility.SD.Role_Cust)]


public class CustomerController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RecommendationService _recommendationService;

    public CustomerController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
        _recommendationService = new RecommendationService(context);
    }

    // Inside CustomerController

    public async Task<IActionResult> Index(string? search, int? categoryId, int? contractTypeId)
    {
        IQueryable<MarketingAgency> allAgencies = _context.MarketingAgency
            
            .Include(a => a.Feedbacks)
            .Include(a => a.MarketingAgencyCategories)
            .ThenInclude(mac => mac.Category)
            .Include(a => a.MarketingAgencyContractTypes)
            .ThenInclude(mact => mact.ContractType);

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

        if (categoryId.HasValue)
        {
            allAgencies = allAgencies.Where(a => a.MarketingAgencyCategories.Any(mac => mac.CategoryId == categoryId));
        }

        if (contractTypeId.HasValue)
        {
            allAgencies = allAgencies.Where(a => a.MarketingAgencyContractTypes.Any(mact => mact.ContractTypeId == contractTypeId));
        }

        List<MarketingAgency> marketingAgencies = await allAgencies.ToListAsync();

        foreach (var agency in marketingAgencies)
        {
            if (agency.Feedbacks.Any())
            {
                agency.Rating = agency.Feedbacks.Average(f => f.Rating);
            }
            else
            {
                agency.Rating = 0;
            }
        }

        var userId = _userManager.GetUserId(User);
        var customer = await _context.Customers.SingleOrDefaultAsync(c => c.applicationUser.Id == userId);
        var recommendations = new List<MarketingAgency>();

        if (customer != null)
        {
            var recommendedAgencies = _recommendationService.RecommendAgencies(customer.CustomerId);
            recommendations = _context.MarketingAgency
                .Where(a => recommendedAgencies.Select(r => r.MarketingAgencyId).Contains(a.MarketingAgencyId))
                .ToList();
        }

        var categories = await _context.Categories.ToListAsync();
        var contractTypes = await _context.ContractTypes.ToListAsync();

        var model = new IndexViewModel
        {
            MarketingAgencies = marketingAgencies,
            RecommendedAgencies = recommendations,
            Categories = categories,
            ContractTypes = contractTypes,
            Search = search,
            CategoryId = categoryId,
            ContractTypeId = contractTypeId
        };

        return View(model);
    }

    public async Task<IActionResult> Payments()
{
        var customerId = await GetCurrentCustomerId();
        var payments = await _context.Payments
        .Where(p => p.CustomerId == customerId)
        .Include(p => p.Customer)
        .Include(p => p.MarketingAgency)
        .ToListAsync();
        return View(payments);
}


    public IActionResult Details(int id)
    {
        // Retrieve the marketing agency including its associated feedbacks and customers
        var agency = _context.MarketingAgency
                             .Include(a => a.Feedbacks) // Include feedbacks
                                 .ThenInclude(f => f.Customer) // Include customers of feedbacks
                             .FirstOrDefault(a => a.MarketingAgencyId == id);

        if (agency == null)
        {
            return NotFound();
        }

        return View(agency);
    }

    public async Task<IActionResult> ViewLocation(int? id)
    {
        var location = await _context.Locations.FirstOrDefaultAsync(a => a.LocationId == id);

        if (location == null)
        {
            return NotFound();
        }

        return View(location);
    }


    [HttpPost]
    public async Task<IActionResult> Book(int MarketingAgencyId, DateTime startDateTime, DateTime endDateTime)
    {
        var userId = _userManager.GetUserId(User);

        var customer = await _context.Customers.SingleOrDefaultAsync(c => c.applicationUser.Id == userId);
        if (customer == null)
        {
            return NotFound("Customer not found.");
        }

        // Check if the slot is available
        var isSlotAvailable = await IsSlotAvailable(MarketingAgencyId, startDateTime, endDateTime);
        if (!isSlotAvailable)
        {
            ModelState.AddModelError(string.Empty, "The selected time slot is not available.");
            TempData["Notification"] = "Slot not available";
            return RedirectToAction("Index");
        }

        var appointment = new Appointment
        {
            MarketingAgencyId = MarketingAgencyId,
            CustomerId = customer.CustomerId,
            StartDateTime = startDateTime,
            EndDateTime = endDateTime,
            Status = "Pending"
        };

        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();

        TempData["Notification"] = "Appointment booked successfully";
        return RedirectToAction("Index");
    }


    private async Task<bool> IsSlotAvailable(int marketingAgencyId, DateTime startDateTime, DateTime endDateTime)
    {
        return !await _context.Appointments.AnyAsync(a =>
            a.MarketingAgencyId == marketingAgencyId &&
            ((startDateTime >= a.StartDateTime && startDateTime < a.EndDateTime) ||
             (endDateTime > a.StartDateTime && endDateTime <= a.EndDateTime)));
    }



    public async Task<IActionResult> SubmitReview()
    {

        Review review = new Review();
        review.CustomerId = "6";
        return View(review);
    }

    [HttpPost]
    public async Task<IActionResult> SubmitReviewAsync(Review review)
    {


        if (ModelState.IsValid)
        {
            // Add the review to the context and save changes
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();

            // Redirect to a thank you page or customer details page
            return RedirectToAction("ThankYou");
        }

        // If the model is not valid or user not found, return to the form with validation errors
        return View(review);
    }



    public IActionResult ThankYou()
    {
        return View();
    }

    public async Task<IActionResult> Portfolio(int? id)
    {
        var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
        return View(posts);
    }

    public async Task<IActionResult> MyRequests()
    {
        var userId = _userManager.GetUserId(User);
        var customer = await _context.Customers
                                    .Include(c => c.Appointments)
                                        .ThenInclude(a => a.MarketingAgency)
                                    .SingleOrDefaultAsync(c => c.applicationUser.Id == userId);
        if (customer == null)
        {
            return NotFound("Customer not found.");
        }

        var today = DateTime.Today;

        // Filter appointments based on status and date conditions
        var appointments = customer.Appointments.Where(a =>
            (a.Status == "Accepted" && a.EndDateTime >= today) ||
            (a.Status == "Pending" && a.StartDateTime > today && a.EndDateTime >= today)
        ).ToList();

        return View(appointments);
    }

    [HttpPost]
    public async Task<IActionResult> DeclineRequest(int appointmentId)
    {
        var appointment = await _context.Appointments.FindAsync(appointmentId);
        if (appointment != null)
        {
            appointment.Status = "Canceled";
            _context.SaveChanges();
        }
        return RedirectToAction("MyRequests");
    }
    [HttpPost]
    public async Task<IActionResult> SubmitFeedback(Feedback feedback)
    {

        var userId = _userManager.GetUserId(User);

        // Find the CustomerId associated with the UserId
        var customer = await _context.Customers.FirstOrDefaultAsync(c => c.applicationUser.Id == userId);

        if (customer != null)
        {
            // Check if the customer has already submitted feedback for this agency
            var existingFeedback = await _context.Feedbacks.FirstOrDefaultAsync(f =>
                f.CustomerId == customer.CustomerId && f.MarketingAgencyId == feedback.MarketingAgencyId);

            if (existingFeedback != null)
            {
                // Update existing feedback
                existingFeedback.Rating = feedback.Rating;
                existingFeedback.Comment = feedback.Comment;
                existingFeedback.Date = DateTime.Now;

                _context.Feedbacks.Update(existingFeedback);
            }
            else
            {
                // If no existing feedback, add new feedback
                feedback.CustomerId = customer.CustomerId;
                feedback.Date = DateTime.Now;
                _context.Feedbacks.Add(feedback);
            }

            await _context.SaveChangesAsync();

            // Redirect to the details view of the marketing agency
            return RedirectToAction("Details", new { id = feedback.MarketingAgencyId });
        }

        // If ModelState is not valid or customer not found, return to the previous page
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Profile()
    {
        // Retrieve the current user (customer)
        ApplicationUser currentUser = (ApplicationUser)await _userManager.GetUserAsync(User);
        if (currentUser == null)
        {
            // Handle the case where the current user is not found
            return NotFound();
        }

        // Find the customer associated with the current user
        Customer customer = await _context.Customers
            .Include(c => c.Feedbacks)
                .ThenInclude(f => f.MarketingAgency)
            .Include(c => c.Appointments)
                .ThenInclude(a => a.MarketingAgency)
            .FirstOrDefaultAsync(c => c.applicationUser.Id == currentUser.Id);

        if (customer == null)
        {
            // Handle the case where the customer for the current user is not found
            return NotFound();
        }

        var today = DateTime.Today;

        // Filter appointments based on specific criteria for the customer
        var filteredAppointments = customer.Appointments
            .Where(a => ((a.Status == "Accepted" && a.EndDateTime >= today) ||
                         (a.Status == "Pending" && a.StartDateTime > today && a.EndDateTime >= today)))
            .ToList();

        // Fetch proposals for the customer
        var proposals = await _context.Proposals
            .Where(p => p.CustomerId == customer.CustomerId && (p.Status == "Accepted" || p.Status == "Pending" || p.Status == "Rejected"))
            .Include(p => p.MarketingAgency)
            .ToListAsync();

        // Calculate appointment statistics
        int acceptedCount = customer.Appointments.Count(a => a.Status == "Accepted");
        int canceledCount = customer.Appointments.Count(a => a.Status == "Canceled");
        int rejectedCount = customer.Appointments.Count(a => a.Status == "Rejected");
        int pendingCount = customer.Appointments.Count(a => a.Status == "Pending");

        // Calculate proposal statistics
        int acceptedProposalsCount = proposals.Count(p => p.Status == "Accepted");
        int rejectedProposalsCount = proposals.Count(p => p.Status == "Rejected");
        int pendingProposalsCount = proposals.Count(p => p.Status == "Pending");

        // Calculate budget statistics for proposals
        double minBudget = proposals.Where(p => p.Status == "Accepted").Select(p => p.MinBudget).DefaultIfEmpty(0).Min();
        double maxBudget = proposals.Where(p => p.Status == "Accepted").Select(p => p.MaxBudget).DefaultIfEmpty(0).Max();
        double avgBudget = proposals.Where(p => p.Status == "Accepted").Select(p => (p.MinBudget + p.MaxBudget) / 2).DefaultIfEmpty(0).Average();

        // Calculate feedback statistics
        int postedFeedbacksCount = customer.Feedbacks.Count();

        // Total number of appointments and proposals
        int totalAppointments = customer.Appointments.Count();
        int totalProposals = proposals.Count();

        // Pass data to the view
        ViewBag.Feedbacks = customer.Feedbacks;
        ViewBag.Appointments = filteredAppointments;
        ViewBag.Proposals = proposals;
        ViewBag.AcceptedCount = acceptedCount;
        ViewBag.CanceledCount = canceledCount;
        ViewBag.RejectedCount = rejectedCount;
        ViewBag.PendingCount = pendingCount;
        ViewBag.AcceptedProposalsCount = acceptedProposalsCount;
        ViewBag.RejectedProposalsCount = rejectedProposalsCount;
        ViewBag.PendingProposalsCount = pendingProposalsCount;
        ViewBag.PostedFeedbacksCount = postedFeedbacksCount;
        ViewBag.TotalAppointments = totalAppointments;
        ViewBag.TotalProposals = totalProposals;
        ViewBag.MinBudget = minBudget;
        ViewBag.MaxBudget = maxBudget;
        ViewBag.AvgBudget = avgBudget;

        return View(customer);
    }


    // GET: Customer/EditProfile
    public async Task<IActionResult> EditProfile()
    {
        // Retrieve the current user
        ApplicationUser currentUser = (ApplicationUser)await _userManager.GetUserAsync(User);

        if (currentUser == null)
        {
            // Handle the case where the current user is not found
            return NotFound();
        }

        // Find the customer associated with the current user
        Customer customer = await _context.Customers
                                            .FirstOrDefaultAsync(c => c.applicationUser.Id == currentUser.Id);

        if (customer == null)
        {
            // Handle the case where the customer for the current user is not found
            return NotFound();
        }

        return View(customer);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditProfile(Customer customer)
    {
        // Retrieve the current user
        var currentUser = await _userManager.GetUserAsync(User);
        customer.applicationUser = (ApplicationUser)currentUser;
        var cus = customer;
       
            try
            {
                // Update the customer profile
                // Set the ApplicationUser reference to the current user


                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Profile");
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound(); // Handle the case where the customer is not found
            }
        
        return View(customer);
    }
    private async Task<string> GetCurrentCustomerId()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user != null)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.applicationUser.Id == user.Id);
            if (customer != null)
            {
                return customer.CustomerId;
            }
        }
        return null;
    }

    public async Task<IActionResult> CreateProposal(int id)
    {
        var customerId = await GetCurrentCustomerId();
        if (customerId == null)
        {
            return Challenge();
        }

        // Fetch the marketing agency with associated categories and contract types
        var agency = await _context.MarketingAgency
            .Include(a => a.MarketingAgencyCategories)
                .ThenInclude(mc => mc.Category)
            .Include(a => a.MarketingAgencyContractTypes)
                .ThenInclude(ct => ct.ContractType)
            .FirstOrDefaultAsync(a => a.MarketingAgencyId == id);

        if (agency == null)
        {
            return NotFound(); // Handle agency not found
        }

        // If no categories or contract types associated with the agency, handle it accordingly
        //if (agency.MarketingAgencyCategories.Count == 0 || agency.MarketingAgencyContractTypes.Count == 0)
        //{
        //    ViewBag.ErrorMessage = "No categories or contract types associated with this agency.";
        //    return View("Error");
        //}

        var proposal = new Proposal
        {
            MarketingAgencyId = id,
            CustomerId = customerId
        };

        // Pass only associated categories and contract types to the view
        ViewBag.CategoryOptions = new SelectList(agency.MarketingAgencyCategories.Select(mc => mc.Category), "CategoryId", "Name");
        ViewBag.ContractTypeOptions = new SelectList(agency.MarketingAgencyContractTypes.Select(ct => ct.ContractType), "ContractTypeId", "Name");

        return View(proposal);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateProposal(Proposal proposal)
    {
        // Check if MinBudget is less than MaxBudget
        if (proposal.MinBudget >= proposal.MaxBudget)
        {
            ModelState.AddModelError("MaxBudget", "Maximum budget must be greater than minimum budget.");
        }
        var p = proposal;

        if (ModelState.IsValid)
        {
            var customerId = await GetCurrentCustomerId();
            if (customerId == null)
            {
                return Challenge();
            }

            proposal.CustomerId = customerId;

            _context.Proposals.Add(proposal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ViewProposals));
        }

        // If ModelState is not valid, return to the form with validation errors
        return View(proposal);
    }


    // GET: /Customer/ViewProposals
    public async Task<IActionResult> ViewProposals()
    {
        var customerId = await GetCurrentCustomerId();
        if (customerId == null)
        {
            return Challenge();
        }

        var proposals = await _context.Proposals
            .Include(p => p.MarketingAgency)  // Eager load MarketingAgency
            .Where(p => p.CustomerId == customerId &&
                        (p.Status == "Accepted" || p.Status == "Pending")) // Filter by Accepted and Pending statuses
            .ToListAsync();

        return View(proposals);
    }

    public async Task<IActionResult> ViewRejectedProposals()
    {
        var customerId = await GetCurrentCustomerId();
        if (customerId == null)
        {
            return Challenge();
        }

        var proposals = await _context.Proposals
            .Include(p => p.MarketingAgency)  // Eager load MarketingAgency
            .Where(p => p.CustomerId == customerId &&
                        (p.Status == "rejected")) // Filter by Accepted and Pending statuses
            .ToListAsync();

        return View(proposals);
    }
    // Method to view reports for the logged-in customer
    // Method to view reports for the logged-in customer
    public async Task<IActionResult> ViewReports()
    {
        var CustomerId = await GetCurrentCustomerId();
        var reports = await _context.Reports
            .Where(r => r.CustomerId == CustomerId)
            .Include(r => r.MarketingAgency)
            .ToListAsync();

        return View(reports);
    }

    // Other methods...

    // Ensure the view for CreateReport
    [HttpGet]
    public IActionResult CreateReport(int marketingAgencyId)
    {
        var report = new Report
        {
            MarketingAgencyId = marketingAgencyId
        };
        return View(report);
    }

    [HttpPost]
    public async Task<IActionResult> CreateReport(Report report)
    {
        
            report.CustomerId = await GetCurrentCustomerId();
            report.CreatedAt = DateTime.Now;
            _context.Reports.Add(report);
            await _context.SaveChangesAsync();
            TempData["Notification"] = "Report created successfully.";
            return RedirectToAction("ViewReports");
        
    }
}

