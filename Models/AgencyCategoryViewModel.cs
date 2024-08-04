using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MarketingHub.Models;

public class AgencyCategoryViewModel
{
    public int MarketingAgencyId { get; set; }
    public int OldCategoryId { get; set; }

    public MarketingAgencyCategory AgencyCategory { get; set; }

    [Display(Name = "Category")]
    public SelectList Categories { get; set; }
}
