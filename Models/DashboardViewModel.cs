using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class DashboardViewModel
    {
        public int CustomerCount { get; set; }
        public int AgencyCount { get; set; }
        public int AdminCount { get; set; }

        public List<Customer> CustomerList { get; set; }
        public List<MarketingAgency> AgencyList { get; set; }

        public Dictionary<string, int> AgencyCategoryCounts { get; set; }
        public Dictionary<string, int> AgencyContractTypeCounts { get; set; }

        // New properties for appointment and proposal statistics
        public Dictionary<string, int> AppointmentStatusCounts { get; set; }
        public Dictionary<string, int> ProposalStatusCounts { get; set; }

        // New properties for post statistics
        public int TotalPostCount { get; set; }
        public List<MarketingAgencyPostCount> Top3AgenciesByPostCount { get; set; }
        public List<MarketingAgencyPostCount> Bottom3AgenciesByPostCount { get; set; }

        // New properties for feedback statistics
        public int TotalFeedbackCount { get; set; }
        public Dictionary<int, int> FeedbackCountsByRating { get; set; }
        public Dictionary<int, int> AgencyCountsByAverageRating { get; set; }

        public List<CustomerDashboardViewModel> CustomerDashboardList { get; set; }
        public int TotalAppointments { get; set; } // Add total appointments
        public int TotalProposals { get; set; }

        // New properties for accepted proposal budget statistics
        public double MinAcceptedBudget { get; set; }
        public double MaxAcceptedBudget { get; set; }
        public double AvgAcceptedBudget { get; set; }
        public int TotalReports { get; set; }

    }
    public class MarketingAgencyPostCount
    {
        public string AgencyName { get; set; }
        public int PostCount { get; set; }
    }

    public class CustomerDashboardViewModel
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TotalAppointments { get; set; }
        public int TotalProposals { get; set; }
        public string Email { get; set;}
    }
}




