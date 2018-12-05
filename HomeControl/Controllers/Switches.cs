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
    public class Switches : Controller
    {
        private readonly ILogger logger;

        public Switches(ILogger<Rooms> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Get all the rooms, lights and switches along with their current state.
        /// </summary>
        /// <returns>An Objest</returns>
        [HttpGet()]
        public IActionResult GetAllDevices()
        {
            this.logger.LogInformation("Getting All Switches");
            string json = JsonConvert.SerializeObject(new { });
            return this.Content(json.ToString(), "application/json");
        }
    }
}
