using BGT.Models;
using Microsoft.AspNetCore.Mvc;

namespace BGT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<GamesController> _logger;

        public GamesController(ILogger<GamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<GameModel> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new GameModel
                {
                })
                .ToArray();
        }
    }
}