using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarketingHub.Models
{
    public class ContractType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractTypeId { get; set; }

        [Required(ErrorMessage = "Contract type name is required")]
        public string Name { get; set; } = "";

        public ICollection<MarketingAgencyContractType> MarketingAgencyContractTypes { get; set; } = new List<MarketingAgencyContractType>();
    }
}
