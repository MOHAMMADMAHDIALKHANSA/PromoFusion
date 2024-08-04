using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReportId { get; set; }

        [Required]
        public string CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        [Required]
        public int MarketingAgencyId { get; set; }

        [ForeignKey("MarketingAgencyId")]
        public MarketingAgency? MarketingAgency { get; set; }

        [Required]
        public string ReportDetails { get; set; }

        public string? RefutationDetails { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? RefutedAt { get; set; }
    }
}
