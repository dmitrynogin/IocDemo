using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IocDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public HomeController(IDemoService service)
        {
            Service = service;
        }

        public IDemoService Service { get; }

        [HttpGet]
        public string Get() => Service.Greet("John Doe");
    }
}
