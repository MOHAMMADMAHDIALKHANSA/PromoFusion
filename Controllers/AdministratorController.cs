using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MarketingHub.Data;
using MarketingHub.Models;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;

[Authorize(Roles =MarketingHub.Utility.SD.Role_Admin)]

public class AdministratorController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public AdministratorController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;

    }
    public async Task<IActionResult> Payments()
    {
        var payments = await _context.Payments.Include(p => p.Customer)
        .Include(p => p.MarketingAgency)
        .ToListAsync();
        return View(payments);
    }

    public async Task<IActionResult> Index(string search , int? category, int? contractType)
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

    public async Task<IActionResult> DisplayAdmin()
    {
        List<Administrator> administrators= await _context.Administrators.ToListAsync();
        return View(administrators);
    }
    [HttpGet]

    public async Task<IActionResult> SearchAdmin(string search)
    {
        var administrators = await _context.Administrators
            .Where(a => a.FirstName.Contains(search) || a.LastName.Contains(search))
            .ToListAsync();

        return View("DisplayAdmin", administrators);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var marketingAgency = await _context.MarketingAgency
            .Include(m => m.Location)
            .Include(m => m.Reports) // Include related reports
            .FirstOrDefaultAsync(m => m.MarketingAgencyId == id);

        if (marketingAgency == null)
        {
            return NotFound();
        }

        // Delete associated reports
        if (marketingAgency.Reports != null)
        {
            _context.Reports.RemoveRange(marketingAgency.Reports);
        }

        // Delete associated locations
        if (marketingAgency.Location != null)
        {
            _context.Remove(marketingAgency.Location);
        }

        // Delete marketing agency
        _context.Remove(marketingAgency);

        await _context.SaveChangesAsync();

        // Delete associated user
        var user = await _userManager.FindByNameAsync(marketingAgency.Username);
        if (user != null)
        {
            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                // Handle the case where user deletion fails
                // Log or display an error message
            }
        }

        return RedirectToAction("Index");
    }


    //public async Task<IActionResult> Delete(int id)
    //{
    //    var marketingAgency = await _context.MarketingAgency
    //        .FirstOrDefaultAsync(m => m.MarketingAgencyId == id);

    //    if (marketingAgency == null)
    //    {
    //        return NotFound();
    //    }

    //    if (marketingAgency.Location != null)
    //    {
    //        _context.Remove(marketingAgency.Location);
    //    }

    //    _context.Remove(marketingAgency);

    //    await _context.SaveChangesAsync();

    //    var user = await _userManager.FindByNameAsync(marketingAgency.Username);
    //    if (user != null)
    //    {
    //        var result = await _userManager.DeleteAsync(user);


    //    }

    //    return RedirectToAction("Index");
    //}


    public async Task<IActionResult> Details(int? id)
    {
        var marketingAgency = await _context.MarketingAgency.FirstOrDefaultAsync(a => a.MarketingAgencyId == id);
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
        var location = await _context.Locations.FirstOrDefaultAsync(a => a.LocationId == id);

        if (location == null)
        {
            return NotFound();
        }

        return View(location);
    }



    [HttpGet]
    public IActionResult AddAgency()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ProcessAddAgency(MarketingAgency marketingAgency)
    {
        // Check if the email already exists in the ApplicationUser table
        var existingUser = await _userManager.FindByEmailAsync(marketingAgency.Email);
        if (existingUser != null)
        {
            ModelState.AddModelError(string.Empty, "Email is already in use.");
            return View("AddAgency", marketingAgency);
        }

        // Create a new ApplicationUser based on the MarketingAgency data
        var user = new ApplicationUser
        {
            UserName = marketingAgency.Username,
            Email = marketingAgency.Email,
            Name = marketingAgency.Username
        };

        // Attempt to create the ApplicationUser
        var result = await _userManager.CreateAsync(user, "Mm_123");

        // Set the UserId property of the MarketingAgency to the Id of the newly created user
        marketingAgency.UserId = user.Id;

        // Check if the ApplicationUser creation was successful
        if (result.Succeeded)
        {
            // Add the MarketingAgency to the context and save changes
            _context.MarketingAgency.Add(marketingAgency);
            await _context.SaveChangesAsync();

            // Redirect to the Index action if successful
            return RedirectToAction("Index");
        }
        else
        {
            // If ApplicationUser creation failed, add errors to ModelState
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        // If ModelState is not valid or ApplicationUser creation failed, return to the view with the model
        return View("AddAgency", marketingAgency);
    }






    public async Task<IActionResult> EditAgency(int? id)
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

        return View(marketingAgency);
    }

   

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ProcessEditAgency(MarketingAgency marketingAgency)
    {
        var mar = marketingAgency;
       

        try
        {
            // Update marketing agency details

            // Find associated application user
            var user = await _userManager.FindByIdAsync(marketingAgency.UserId);

            if (user != null)
            {
                // Update user email if changed
                if (user.Email != marketingAgency.Email)
                {
                    user.Email = marketingAgency.Email;
                    await _userManager.UpdateAsync(user);
                }

                user.UserName = marketingAgency.Username; // Always update username

                // Update user in the context
                _context.Update(user);
            }

            // Update location ID
            marketingAgency.Location.LocationId = (int)marketingAgency.LocationId;

            // Update marketing agency in the context
            _context.MarketingAgency.Update(marketingAgency);

            // Find existing location
            var existingLocation = await _context.Locations.FindAsync(marketingAgency.LocationId);
            if (existingLocation != null)
            {
                // Update location details
                existingLocation = marketingAgency.Location;

                // Update location in the context
                _context.Locations.Update(existingLocation);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        catch (DbUpdateConcurrencyException)
        {
            return NotFound(); // MarketingAgency with given ID not found
        }
        if (!ModelState.IsValid)
        {
            // If ModelState is not valid, return to the EditAgency view with the model to show validation errors
            return View("EditAgency", marketingAgency);
        }
    }


    public async Task<IActionResult> ViewDetails(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var admin = await _context.Administrators.FirstOrDefaultAsync(a => a.AdministratorId == id);

        if (admin == null)
        {
            return NotFound();
        }

        return View(admin);
    }

    public async Task<IActionResult> Portfolio(int id)
    {
        ViewBag.MarketingAgencyId = id;
        var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
        return View(posts);
    }

    [HttpPost]
    public async Task<IActionResult> UploadPost(int id, string caption, string videoLink, string pictureLink)
    {
        try
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

            return RedirectToAction("Portfolio", new { id });
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = "An error occurred while processing your request.";
            ViewBag.MarketingAgencyId = id;
            var posts = await _context.Posts.Where(p => p.MarketingAgencyId == id).ToListAsync();
            return View("Portfolio", posts);
        }
    }






    [HttpPost]
    public async Task<IActionResult> DeletePost(int id)
    {
        try
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return RedirectToAction("Portfolio", new { id = post.MarketingAgencyId });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            ViewBag.ErrorMessage = "An error occurred while processing your request.";
            return View("Error");
        }
    }

    [HttpPost]
    public async Task<IActionResult> EditPost(int id, string caption, string videoLink, string pictureLink)
    {
        try
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

            return RedirectToAction("Portfolio", new { id = post.MarketingAgencyId });
        }
        catch (Exception ex)
        {
            ViewBag.ErrorMessage = "An error occurred while processing your request.";
            var posts = await _context.Posts.ToListAsync();
            return View("Portfolio", posts);
        }
    }

    [HttpGet]
    public IActionResult AddAdmin()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ProcessAddAdmin(Administrator administrator)
    {
        var existingUser = await _userManager.FindByEmailAsync(administrator.Email);
        if (existingUser != null)
        {
            ModelState.AddModelError(string.Empty, "Email is already in use.");
            return View("AddAdmin", administrator);
        }
        var user = new ApplicationUser
        {
            UserName = administrator.Email,
            Email = administrator.Email,
            Name = administrator.FirstName + " " + administrator.LastName,
        };
        var result = await _userManager.CreateAsync(user, "Mm_123");
        administrator.UserId = user.Id;
        if (result.Succeeded)
        {
            _context.Administrators.Add(administrator);
            await _context.SaveChangesAsync();
            return RedirectToAction("displayAdmin");
        }
        else
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View("AddAdmin", administrator);
    }

    public async Task<IActionResult> DeleteAdmin(int id)
    {
        var administrator = await _context.Administrators.FindAsync(id);

        if (administrator == null)
        {
            return NotFound();
        }

        // Delete marketing agency
        _context.Remove(administrator);

        await _context.SaveChangesAsync();

        // Delete associated user
        var user = await _userManager.FindByNameAsync(administrator.Email);
        if (user != null)
        {
            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                // Handle the case where user deletion fails
                // You might want to log or display an error message
            }
        }

        return RedirectToAction("displayAdmin");
    }

    public async Task<IActionResult> EditAdmin(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var administrator = await _context.Administrators.FindAsync(id);

        if (administrator == null)
        {
            return NotFound();
        }
        return View(administrator);
    }



    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ProcessEditAdmin(Administrator administrator)
    {
        

        try
        {
            // Update marketing agency details

            // Find associated application user
            var user = await _userManager.FindByIdAsync(administrator.UserId);

            if (user != null)
            {
                // Update user email if changed
                if (user.Email != administrator.Email)
                {
                    user.Email = administrator.Email;
                    await _userManager.UpdateAsync(user);
                }

                // Update user in the context
                _context.applicationUsers.Update((ApplicationUser)user);
            }

            // Update location ID

            // Update marketing agency in the context
            _context.Administrators.Update(administrator);

            await _context.SaveChangesAsync();

            return RedirectToAction("displayAdmin");
        }
        catch (DbUpdateConcurrencyException)
        {
            return NotFound(); // MarketingAgency with given ID not found
        }
    }

    public async Task<IActionResult> ManageAgencyCategories()
    {
        var categories = await _context.MarketingAgencyCategory
            .Include(m => m.MarketingAgency)
            .Include(c => c.Category)
            .ToListAsync();
        return View(categories);
    }
    [HttpGet]
    public async Task<IActionResult> AddAgencyCategory()
    {
        var model = new MarketingAgencyCategory(); // Create an instance of the model
                                                   // Populate the dropdown lists
        ViewData["MarketingAgencyId"] = new SelectList(await _context.MarketingAgency.ToListAsync(), "MarketingAgencyId", "Username");
        ViewData["CategoryId"] = new SelectList(await _context.Categories.ToListAsync(), "CategoryId", "Name");

        return View(model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddAgencyCategory(MarketingAgencyCategory agencyCategory)
    {
        if (ModelState.IsValid)
        {
            bool exists = await _context.MarketingAgencyCategory
                .AnyAsync(ac => ac.MarketingAgencyId == agencyCategory.MarketingAgencyId &&
                                ac.CategoryId == agencyCategory.CategoryId);

            if (exists)
            {
                ModelState.AddModelError(string.Empty, "This combination of Marketing Agency and Category already exists.");
                ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyCategory.MarketingAgencyId);
                ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", agencyCategory.CategoryId);
                return View(agencyCategory);
            }

            _context.MarketingAgencyCategory.Add(agencyCategory);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Category added successfully.";
            return RedirectToAction(nameof(ManageAgencyCategories));
        }

        ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyCategory.MarketingAgencyId);
        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", agencyCategory.CategoryId);
        return View(agencyCategory);
    }

    [HttpGet]
    public async Task<IActionResult> EditAgencyCategory(int marketingAgencyId, int categoryId)
    {
        Console.WriteLine($"Marketing Agency ID: {marketingAgencyId}, Category ID: {categoryId}");

        var agencyCategory = await _context.MarketingAgencyCategory
            .FirstOrDefaultAsync(ac => ac.MarketingAgencyId == marketingAgencyId && ac.CategoryId == categoryId);

        if (agencyCategory == null)
        {
            Console.WriteLine("Agency category not found.");
            return NotFound();
        }

        // Fetch the list of categories
        var categories = await _context.Categories.ToListAsync();

        // Pass categories to ViewBag as SelectList
        ViewBag.Categories = new SelectList(categories, "CategoryId", "Name", agencyCategory.CategoryId);

        return View(agencyCategory);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAgencyCategory(int marketingAgencyId, int oldCategoryId, MarketingAgencyCategory agencyCategory)
    {
        if (ModelState.IsValid)
        {
            try
            {
                bool exists = await _context.MarketingAgencyCategory
                    .AnyAsync(ac => ac.MarketingAgencyId == marketingAgencyId &&
                                    ac.CategoryId == oldCategoryId);

                if (exists)
                {
                    // Delete the existing entity
                    var existingAgencyCategory = await _context.MarketingAgencyCategory
                        .FirstOrDefaultAsync(ac => ac.MarketingAgencyId == marketingAgencyId && ac.CategoryId == oldCategoryId);

                    if (existingAgencyCategory == null)
                    {
                        return NotFound();
                    }

                    _context.MarketingAgencyCategory.Remove(existingAgencyCategory);

                    // Add a new entity with the updated CategoryId
                    var newAgencyCategory = new MarketingAgencyCategory
                    {
                        MarketingAgencyId = marketingAgencyId,
                        CategoryId = agencyCategory.CategoryId
                    };

                    _context.MarketingAgencyCategory.Add(newAgencyCategory);

                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Category updated successfully.";
                    return RedirectToAction(nameof(ManageAgencyCategories));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Agency category not found.");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Error occurred while saving: category type already found" );
            }
        }

        // If ModelState is not valid, reload the SelectList for Categories
        ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "Name", agencyCategory.CategoryId);
        return View(agencyCategory);
    }


    private bool MarketingAgencyCategoryExists(int marketingAgencyId, int categoryId)
    {
        return _context.MarketingAgencyCategory.Any(ac => ac.MarketingAgencyId == marketingAgencyId && ac.CategoryId == categoryId);
    }



    public async Task<IActionResult> DeleteAgencyCategory(int marketingAgencyId, int categoryId)
    {
        var agencyCategory = await _context.MarketingAgencyCategory.FindAsync(marketingAgencyId, categoryId);

        if (agencyCategory == null)
        {
            return NotFound();
        }

        _context.MarketingAgencyCategory.Remove(agencyCategory);
        await _context.SaveChangesAsync();

        return RedirectToAction("ManageAgencyCategories"); // Correct redirection
    }

    


    public async Task<IActionResult> ManageAgencyContractTypes()
    {
        var contractTypes = await _context.MarketingAgencyContractTypes
            .Include(m => m.MarketingAgency)
            .Include(c => c.ContractType)
            .ToListAsync();
        return View(contractTypes);
    }

    [HttpGet]
    public IActionResult AddAgencyContractType()
    {
        // Fetch the list of agencies
        var agencies = _context.MarketingAgency.ToList();

        // Fetch the list of contract types
        var contractTypes = _context.ContractTypes.ToList();

        // Pass agencies and contract types to ViewBag
        ViewBag.Agencies = new SelectList(agencies, "MarketingAgencyId", "Username");
        ViewBag.ContractTypes = new SelectList(contractTypes, "ContractTypeId", "Name");

        return View();
    }




    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddAgencyContractType(MarketingAgencyContractType agencyContractType)
    {
        if (ModelState.IsValid)
        {
            bool exists = await _context.MarketingAgencyContractTypes
                .AnyAsync(ac => ac.MarketingAgencyId == agencyContractType.MarketingAgencyId &&
                                ac.ContractTypeId == agencyContractType.ContractTypeId);

            if (exists)
            {
                ModelState.AddModelError(string.Empty, "This combination of Marketing Agency and Contract Type already exists.");
                ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyContractType.MarketingAgencyId);
                ViewBag.ContractTypes = new SelectList(_context.ContractTypes, "ContractTypeId", "Name", agencyContractType.ContractTypeId);
                return View(agencyContractType);
            }

            _context.MarketingAgencyContractTypes.Add(agencyContractType);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Contract Type added successfully.";
            return RedirectToAction(nameof(ManageAgencyContractTypes));
        }

        ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyContractType.MarketingAgencyId);
        ViewBag.ContractTypes = new SelectList(_context.ContractTypes, "ContractTypeId", "Name", agencyContractType.ContractTypeId);
        return View(agencyContractType);
    }


    [HttpGet]
    public async Task<IActionResult> EditAgencyContractType(int marketingAgencyId, int contractTypeId)
    {
        Console.WriteLine($"Marketing Agency ID: {marketingAgencyId}, Contract Type ID: {contractTypeId}");

        var agencyContractType = await _context.MarketingAgencyContractTypes
            .FirstOrDefaultAsync(act => act.MarketingAgencyId == marketingAgencyId && act.ContractTypeId == contractTypeId);

        if (agencyContractType == null)
        {
            Console.WriteLine("Agency contract type not found.");
            return NotFound();
        }

        // Fetch the list of contract types
        var contractTypes = await _context.ContractTypes.ToListAsync();

        // Pass contract types to ViewBag as SelectList
        ViewBag.ContractTypes = new SelectList(contractTypes, "ContractTypeId", "Name", agencyContractType.ContractTypeId);

        return View(agencyContractType);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAgencyContractType(int marketingAgencyId, int oldContractTypeId, MarketingAgencyContractType agencyContractType)
    {
        if (ModelState.IsValid)
        {
            try
            {
                bool exists = await _context.MarketingAgencyContractTypes
                    .AnyAsync(act => act.MarketingAgencyId == marketingAgencyId &&
                                    act.ContractTypeId == oldContractTypeId);

                if (exists)
                {
                    // Delete the existing entity
                    var existingAgencyContractType = await _context.MarketingAgencyContractTypes
                        .FirstOrDefaultAsync(act => act.MarketingAgencyId == marketingAgencyId && act.ContractTypeId == oldContractTypeId);

                    if (existingAgencyContractType == null)
                    {
                        return NotFound();
                    }

                    _context.MarketingAgencyContractTypes.Remove(existingAgencyContractType);

                    // Add a new entity with the updated ContractTypeId
                    var newAgencyContractType = new MarketingAgencyContractType
                    {
                        MarketingAgencyId = marketingAgencyId,
                        ContractTypeId = agencyContractType.ContractTypeId
                    };

                    _context.MarketingAgencyContractTypes.Add(newAgencyContractType);

                    await _context.SaveChangesAsync();
                    TempData["SuccessMessage"] = "Contract type updated successfully.";
                    return RedirectToAction(nameof(ManageAgencyContractTypes));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Agency contract type not found.");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Error occurred while saving: " + ex.Message);
            }
        }

        // If ModelState is not valid, reload the SelectList for ContractTypes
        ViewBag.ContractTypes = new SelectList(_context.ContractTypes, "ContractTypeId", "Name", agencyContractType.ContractTypeId);
        return View(agencyContractType);
    }



    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> EditAgencyContractType(MarketingAgencyContractType agencyContracTyoe)
    //{
    //    if (ModelState.IsValid)
    //    {
    //        bool exists = await _context.MarketingAgencyContractTypes
    //            .AnyAsync(ac => ac.MarketingAgencyId == agencyContracTyoe.MarketingAgencyId &&
    //                            ac.ContractTypeId == agencyContracTyoe.ContractTypeId &&
    //                            !(ac.MarketingAgencyId == agencyContracTyoe.MarketingAgencyId &&
    //                              ac.ContractTypeId == agencyContracTyoe.ContractTypeId));

    //        if (exists)
    //        {
    //            ModelState.AddModelError(string.Empty, "This combination of Marketing Agency and Contract Type already exists.");
    //            ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyContracTyoe.MarketingAgencyId);
    //            ViewBag.ContractTypes = new SelectList(_context.ContractTypes, "ContractTypeId", "Name", agencyContracTyoe.ContractTypeId);
    //            return View(agencyContracTyoe);
    //        }

    //        try
    //        {
    //            // Retrieve the existing entity from the database
    //            var existingContractType = await _context.MarketingAgencyContractTypes
    //                .FirstOrDefaultAsync(ac => ac.MarketingAgencyId == agencyContracTyoe.MarketingAgencyId &&
    //                                             ac.ContractTypeId == agencyContracTyoe.ContractTypeId);

    //            if (existingContractType == null)
    //            {
    //                return NotFound();
    //            }

    //            // Update the ContractTypeId
    //            existingContractType.ContractTypeId = agencyContracTyoe.ContractTypeId;

    //            _context.Update(existingContractType);
    //            await _context.SaveChangesAsync();
    //            TempData["SuccessMessage"] = "Contract Type updated successfully.";
    //            return RedirectToAction(nameof(ManageAgencyContractTypes));
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!MarketingAgencyContractTypeExists(agencyContracTyoe.MarketingAgencyId, agencyContracTyoe.ContractTypeId))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }
    //    }

    //    // If ModelState is not valid, reload the SelectList for Agencies and ContractTypes
    //    ViewBag.Agencies = new SelectList(_context.MarketingAgency, "MarketingAgencyId", "Username", agencyContracTyoe.MarketingAgencyId);
    //    ViewBag.ContractTypes = new SelectList(_context.ContractTypes, "ContractTypeId", "Name", agencyContracTyoe.ContractTypeId);
    //    return View(agencyContracTyoe);
    //}






    private bool MarketingAgencyContractTypeExists(int marketingAgencyId, int contractTypeId)
    {
        return _context.MarketingAgencyContractTypes.Any(ac => ac.MarketingAgencyId == marketingAgencyId && ac.ContractTypeId == contractTypeId);
    }



    
    public async Task<IActionResult> DeleteAgencyContractType(int marketingAgencyId, int contractTypeId)
    {
        var contractType = await _context.MarketingAgencyContractTypes.FindAsync(marketingAgencyId, contractTypeId);

        if (contractType == null)
        {
            return NotFound();
        }

        _context.MarketingAgencyContractTypes.Remove(contractType);
        await _context.SaveChangesAsync();

        return RedirectToAction("ManageAgencyContractTypes"); // Correct redirection
    }

    public IActionResult Reports()
    {
        var reports = _context.Reports
            .Include(r => r.Customer)
            .Include(r => r.MarketingAgency)
            .ToList();

        return View(reports);
    }


}


