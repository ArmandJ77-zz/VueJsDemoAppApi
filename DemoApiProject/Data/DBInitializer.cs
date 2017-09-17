using System.Linq;
using DemoApiProject.Data.Seed;

namespace DemoApiProject.Data
{
  public static class DbInitializer
  {
    public static void Initialize(ApplicationDbContext context)
    {
      context.Database.EnsureCreated();

      if (!context.Clients.Any())
        ClientSeed.Clients.ForEach(x => context.Clients.Add(x));

      if (!context.Products.Any())
        ProductSeed.Product.ForEach(x => context.Products.Add(x));

      context.SaveChanges();
    }
  }
}
