using DemoApiProject.Data;
using DemoApiProject.Infrastructure;
using DemoApiProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DemoApiProject.Controller
{
  public class ClientController : BaseController
  {
    public ClientController(ApplicationDbContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<JsonResult> Get() => new JsonResult(await Context.Clients.ToListAsync());

    [HttpGet]
    [Route("/api/[controller]/GetPaginated")]
    public async Task<JsonResult> GetPaginated(int? page, int pageSize) => new JsonResult(await PaginatedList<Client>.CreateAsync(Context.Clients.AsNoTracking(), page ?? 1, pageSize));
  }
}
