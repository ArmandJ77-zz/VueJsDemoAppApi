using DemoApiProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DemoApiProject.Controller
{
    [Route("/api/[controller]")]
    public class BaseController : Microsoft.AspNetCore.Mvc.Controller
    {
        public ApplicationDbContext Context;

        public BaseController(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
