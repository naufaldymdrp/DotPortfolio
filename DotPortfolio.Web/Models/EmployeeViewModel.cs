namespace DotPortfolio.Web.Models;

using System.ComponentModel.DataAnnotations;

public class EmployeeViewModel
{
    public int Id { get; set; }

    [StringLength(10, MinimumLength = 5)]
    public string Name { get; set; } = null!;

    [Display(Name = "Employ Date")]
    [DataType(DataType.Date)]
    public DateTime EmployDate { get; set; }

    [Display(Name = "Creation Date")]
    public DateTime CreationDate { get; set; }
}
