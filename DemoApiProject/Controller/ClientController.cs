using System;
using System.Net;
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

        [HttpPost]
        public async Task<JsonResult> Create(Client clientDto)
        {
            try
            {
                await Context.Clients.AddAsync(clientDto);
                await Context.SaveChangesAsync();
                return new JsonResult(new { message = "Saved" });

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new JsonResult(new { message = "Failed" });
            }
        }

        [HttpDelete]
        public async Task<JsonResult> Delete(int? Id)
        {
            if (Id == null)
                return new JsonResult(NotFound());

            var client = await Context.Clients
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == Id);

            if (client == null)
                return new JsonResult(NotFound());

            try
            {
                Context.Clients.Remove(client);
                await Context.SaveChangesAsync();
                return new JsonResult(Ok());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new JsonResult(HttpStatusCode.InternalServerError);
            }
        }


    }
}
