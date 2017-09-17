using DemoApiProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DemoApiProject.Controller
{
  public class ProductController : BaseController
    {
      public ProductController(ApplicationDbContext context) : base(context)
      {
      }

      [HttpGet]
      public async Task<JsonResult> Get() => new JsonResult(await Context.Products.ToListAsync());
  }
}
