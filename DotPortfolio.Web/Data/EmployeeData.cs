namespace DotPortfolio.Web.Data;

public class EmployeeData
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime EmployDate { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
