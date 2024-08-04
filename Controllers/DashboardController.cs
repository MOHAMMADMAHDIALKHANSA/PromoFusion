using MarketingHub.Data;
using MarketingHub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarketingHub.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customerCount = _context.Customers.Count();
            var agencyCount = _context.MarketingAgency.Count();
            var adminCount = _context.Administrators.Count();

            var customerList = _context.Customers.ToList();
            var agencyList = _context.MarketingAgency.ToList();
            var totalAppointments = CalculateTotalAppointments();
            var totalProposals = CalculateTotalProposals();

            var acceptedProposals = _context.Proposals
                 .Where(p => p.Status == "Accepted")
                 .ToList();

            double minAcceptedBudget = 0;
            double maxAcceptedBudget = 0;
            double avgAcceptedBudget = 0;

            if (acceptedProposals.Any())
            {
                minAcceptedBudget = acceptedProposals.Min(p => p.MinBudget);
                maxAcceptedBudget = acceptedProposals.Max(p => p.MaxBudget);
                avgAcceptedBudget = acceptedProposals.Average(p => (p.MinBudget + p.MaxBudget) / 2);
            }

            // Calculate agency categories counts
            var agencyCategoryCounts = _context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Count = c.MarketingAgencyCategories.Count()
                })
                .ToDictionary(x => x.CategoryName, x => x.Count);

            // Calculate agency contract types counts
            var agencyContractTypeCounts = _context.ContractTypes
                .Select(ct => new
                {
                    ContractTypeName = ct.Name,
                    Count = ct.MarketingAgencyContractTypes.Count()
                })
                .ToDictionary(x => x.ContractTypeName, x => x.Count);

            // Calculate appointment status counts
            var appointmentStatusCounts = _context.Appointments
                .GroupBy(a => a.Status)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToDictionary(x => x.Status, x => x.Count);

            // Calculate proposal status counts
            var proposalStatusCounts = _context.Proposals
                .GroupBy(p => p.Status)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToDictionary(x => x.Status, x => x.Count);

            // Calculate post counts
            var totalPostCount = _context.Posts.Count();

            var agencyPostCounts = _context.MarketingAgency
                .Select(a => new
                {
                    AgencyName = a.Username,
                    PostCount = a.Post.Count()
                })
                .OrderByDescending(a => a.PostCount)
                .ToList();

            var top3AgenciesByPostCount = agencyPostCounts.Take(3)
                .Select(a => new MarketingAgencyPostCount
                {
                    AgencyName = a.AgencyName,
                    PostCount = a.PostCount
                })
                .ToList();

            var bottom3AgenciesByPostCount = agencyPostCounts.OrderBy(a => a.PostCount).Take(3)
                .Select(a => new MarketingAgencyPostCount
                {
                    AgencyName = a.AgencyName,
                    PostCount = a.PostCount
                })
                .ToList();

            // Calculate feedback statistics
            var totalFeedbackCount = _context.Feedbacks.Count();

            var feedbackCountsByRating = _context.Feedbacks
                .GroupBy(f => f.Rating)
                .Select(g => new
                {
                    Rating = g.Key,
                    Count = g.Count()
                })
                .ToDictionary(x => x.Rating, x => x.Count);
            var agencyCountsByAverageRating = _context.MarketingAgency
         .Select(a => new
         {
             AgencyId = a.MarketingAgencyId,
             AverageRating = _context.Feedbacks
                 .Where(f => f.MarketingAgencyId == a.MarketingAgencyId)
                 .Select(f => (double?)f.Rating)
                 .DefaultIfEmpty()
                 .Average() ?? 0
         })
         .GroupBy(a => (int)Math.Round(a.AverageRating))
         .Select(g => new
         {
             Rating = g.Key,
             Count = g.Count()
         })
         .ToDictionary(x => x.Rating, x => x.Count);


            // Calculate total appointments and proposals per customer
            var customerDashboardList = _context.Customers
                .Select(customer => new CustomerDashboardViewModel
                {
                    CustomerId = customer.CustomerId,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    TotalAppointments = customer.Appointments.Count(),
                    TotalProposals = customer.Proposals.Count(),
                })
                .ToList();


            var totalReports = _context.Reports.Count();

            

            var dashboardModel = new DashboardViewModel
            {
                CustomerCount = customerCount,
                AgencyCount = agencyCount,
                AdminCount = adminCount,
                CustomerList = customerList,
                AgencyList = agencyList,
                AgencyCategoryCounts = agencyCategoryCounts,
                AgencyContractTypeCounts = agencyContractTypeCounts,
                AppointmentStatusCounts = appointmentStatusCounts,
                ProposalStatusCounts = proposalStatusCounts,
                TotalPostCount = totalPostCount,
                Top3AgenciesByPostCount = top3AgenciesByPostCount,
                Bottom3AgenciesByPostCount = bottom3AgenciesByPostCount,
                TotalFeedbackCount = totalFeedbackCount,
                FeedbackCountsByRating = feedbackCountsByRating,
                AgencyCountsByAverageRating = agencyCountsByAverageRating,
                CustomerDashboardList = customerDashboardList,
                TotalAppointments = totalAppointments,
                TotalProposals = totalProposals,
                MinAcceptedBudget = minAcceptedBudget,
                MaxAcceptedBudget = maxAcceptedBudget,
                AvgAcceptedBudget = avgAcceptedBudget,
                TotalReports = totalReports


            };

            return View(dashboardModel);
        }




        private int CalculateTotalAppointments()
        {
            return _context.Appointments.Count();
        }

        private int CalculateTotalProposals()
        {
            return _context.Proposals.Count();
        }

    }


}



