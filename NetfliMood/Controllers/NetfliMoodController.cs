using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetfliMood.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetfliMoodController : ControllerBase
    {

        private readonly ILogger<NetfliMoodController> _logger;

        public NetfliMoodController(ILogger<NetfliMoodController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetMovies()
        {
            return string.Empty;
        }
    }
}
