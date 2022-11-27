namespace DotPortfolio.Web.Data;

using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<EmployeeData>()
            .HasData(
                new EmployeeData 
                { 
                    Id = 1,
                    Name = "Nomad",
                    EmployDate = DateTime.Now,
                    CreationDate = DateTime.Now,
                },
                new EmployeeData
                {
                    Id = 2,
                    Name = "Nopal",
                    EmployDate = DateTime.Now,
                    CreationDate = DateTime.Now
                }
            );
    }

    public DbSet<EmployeeData> Employees => Set<EmployeeData>();
}
