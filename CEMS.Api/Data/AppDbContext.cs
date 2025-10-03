using Microsoft.EntityFrameworkCore;
using CEMS.Api.Data.Models;

//Adding the data entity to  the namespace
namespace CEMS.Api.Data
{
  //Declaring that this class object is of type AppDbContext 
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Employee> Employees { get; set; }

    //Correcting warning from EntityFramework
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      //configure column type. 
      //This will explicity tell EF Core that the salary column is a decimal type
      //other wise it defaults to 18,2
      modelBuilder.Eneity<Employees>().Property(e => e.Salary)
      .HasColumnType("decimal, 10,2)");
    }
    
  }
}
