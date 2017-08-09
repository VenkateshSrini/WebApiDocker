using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
namespace WebApiDocker.Controllers
{
    public class EnvDetails
    {
        public Guid EnvironmentGuid { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string MachineName { get; private set; }
        public EnvDetails()
        {
            EnvironmentGuid = Guid.NewGuid();
            ExpiryDate = DateTime.UtcNow.AddHours(1);
            MachineName = Environment.MachineName;
        }
    }
    [Route("api/[controller]")]
    public class EnvController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(new EnvDetails());
        }
    }
}
