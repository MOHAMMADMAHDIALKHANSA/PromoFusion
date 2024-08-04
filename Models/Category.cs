using MarketingHub.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "Category name is required")]
    public string Name { get; set; } = "";

    public ICollection<MarketingAgencyCategory> MarketingAgencyCategories { get; set; } = new List<MarketingAgencyCategory>();
}
