using DemoApiProject.Model;
using Microsoft.EntityFrameworkCore;

namespace DemoApiProject.Data
{
  public class ApplicationDbContext : DbContext
  {

    public DbSet<Client> Clients { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Sale> Sales { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Client>().ToTable("Clients");
      modelBuilder.Entity<Product>().ToTable("Products");
      modelBuilder.Entity<Sale>().ToTable("Sales");
    }
  }
}
