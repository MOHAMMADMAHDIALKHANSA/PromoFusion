namespace MarketingHub.Models
{
    public class IndexViewModel
    {
        public List<MarketingAgency> MarketingAgencies { get; set; } = new List<MarketingAgency>();
        public List<MarketingAgency> RecommendedAgencies { get; set; } = new List<MarketingAgency>();
        public string? Search { get; set; }
        public int? CategoryId { get; set; }
        public int? ContractTypeId { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public List<ContractType> ContractTypes { get; set; } = new List<ContractType>();
    }

}
