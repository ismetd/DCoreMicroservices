using System.ComponentModel.DataAnnotations;

namespace FreeCourse.Web.Models.Catalogs;

public class FeatureViewModel
{
    [Display(Name = "Kurs süre")]
    public int Duration { get; set; }
}
