using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class MarketingAgencyContractType
    {
        [ForeignKey("MarketingAgencyId")]
        public int MarketingAgencyId { get; set; }
        public MarketingAgency? MarketingAgency { get; set; }
        [ForeignKey("ContractTypeId")]
        public int ContractTypeId { get; set; }
        public ContractType? ContractType { get; set; }
    }
}
