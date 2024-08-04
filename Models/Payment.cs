using System.ComponentModel.DataAnnotations.Schema;
namespace MarketingHub.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string CustomerId { get; set; }
        public int MarketingAgencyId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Customer Customer { get; set; }
        public MarketingAgency MarketingAgency { get; set; }
    }
}
