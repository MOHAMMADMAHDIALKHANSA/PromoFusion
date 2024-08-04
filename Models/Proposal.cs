using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class Proposal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProposalId { get; set; }

        [Required]
        public string CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required]
        public int MarketingAgencyId { get; set; }
        public MarketingAgency? MarketingAgency { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Minimum budget must be a positive value")]
        public double MinBudget { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Maximum budget must be a positive value")]
        public double MaxBudget { get; set; }

        [Required]
        public string Details { get; set; } = "";

        public string? Status { get; set; } = "Pending"; // Pending, Accepted, Rejected

        public string? RejectionReason { get; set; }
        public string? AcceptanceNotes { get; set; }

        // Navigation property for Category
        [Required(ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Navigation property for ContractType
        [Required(ErrorMessage = "Please select a contract type")]
        public int ContractTypeId { get; set; }
        public ContractType? ContractType { get; set; }
    }
}
