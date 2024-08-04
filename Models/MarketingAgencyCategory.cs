using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class MarketingAgencyCategory
    {
        [ForeignKey("MarketingAgencyId")]
        public int MarketingAgencyId { get; set; }
        public MarketingAgency? MarketingAgency { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
