using MarketingHub.Data;
using MarketingHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var customerCount = await GetTotalCustomersAndAgenciesAsync();
            var totalProposals = await GetTotalProposalsAsync();
            var totalAppointments = await GetTotalAppointmentsAsync();

            var dashboardViewModel = new DashboardViewModel
            {
                CustomerCount = customerCount,
                TotalProposals = totalProposals,
                TotalAppointments = totalAppointments
            };

            // Fetch three random marketing agencies
            var marketingAgencies = await _context.MarketingAgency
                                                  .OrderBy(r => Guid.NewGuid())
                                                  .Take(3)
                                                  .Include(ma => ma.Post)  // Include posts for each marketing agency
                                                  .ToListAsync();

            // Select one random post from each marketing agency
            var randomPosts = marketingAgencies.Select(ma => ma.Post.OrderBy(r => Guid.NewGuid()).FirstOrDefault())
                                               .Where(post => post != null)
                                               .ToList();

            ViewData["RandomPosts"] = randomPosts;

            return View(dashboardViewModel);
        }
        private async Task<int> GetTotalCustomersAndAgenciesAsync()
        {
            var customerCount = await _context.Customers.CountAsync();
            var agencyCount = await _context.MarketingAgency.CountAsync();
            return customerCount + agencyCount;
        }

        private async Task<int> GetTotalProposalsAsync()
        {
            var acceptedProposalsCount = await _context.Proposals.CountAsync(p => p.Status == "Accepted");
            var pendingProposalsCount = await _context.Proposals.CountAsync(p => p.Status == "Pending");
            return acceptedProposalsCount + pendingProposalsCount;
        }

        private async Task<int> GetTotalAppointmentsAsync()
        {
            var acceptedAppointmentsCount = await _context.Appointments.CountAsync(a => a.Status == "Accepted");
            var pendingAppointmentsCount = await _context.Appointments.CountAsync(a => a.Status == "Pending");
            return acceptedAppointmentsCount + pendingAppointmentsCount;
        }

    
    public async Task<IActionResult> Privacy()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            List<Administrator> administrators = await _context.Administrators.ToListAsync();
            return View(administrators);
        }

        public async Task<IActionResult> ContactUs()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            // Your asynchronous logic goes here if needed
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
    }
}
