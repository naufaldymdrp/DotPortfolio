namespace DotPortfolio.Web.Models;

using System.ComponentModel.DataAnnotations;

public class EmployeeViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [Display(Name = "Employ Date")]
    public DateTime EmployDate { get; set; }

    public DateTime CreationDate { get; set; }
}
