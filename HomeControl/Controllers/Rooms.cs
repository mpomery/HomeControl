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
    public class Rooms : Controller
    {
        private readonly ILogger logger;

        public Rooms(ILogger<Rooms> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Get all the rooms, lights and switches along with their current state.
        /// </summary>
        /// <returns>An Objest</returns>
        [HttpGet()]
        public IActionResult GetAllRooms()
        {
            this.logger.LogInformation("Getting All Rooms");
            string json = JsonConvert.SerializeObject(new { });
            return this.Content(json.ToString(), "application/json");
        }

        [HttpPost("{roomId}")]
        public IActionResult UpdateRoom(int roomId)
        {
            this.logger.LogInformation("Updating room {0}", roomId);
            string json = JsonConvert.SerializeObject(new { });
            return this.Content(json.ToString(), "application/json");
        }
    }
}
