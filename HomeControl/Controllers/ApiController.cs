using System.Diagnostics;
using HomeControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HomeControl.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        private readonly ILogger logger;

        public ApiController(ILogger<ApiController> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Get all the rooms, lights and switches along with their current state.
        /// </summary>
        /// <returns>An Objest</returns>
        [HttpGet()]
        public IActionResult Index()
        {
            this.logger.LogInformation("Home Page Requested");
            string json = JsonConvert.SerializeObject(new {});
            return Content(json.ToString(), "application/json");
        }
    }
}
