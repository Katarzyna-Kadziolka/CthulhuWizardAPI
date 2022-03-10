using CthulhuWizard.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace CthulhuWizard.API.Controllers;


[ApiController]
[Route("api/v1/[controller]")]
[ApiVersion( "1.0" )]
public class WeatherForecastController : ControllerBase {
    private static readonly string[] Summaries = new[] {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IRavenDbContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IRavenDbContext context) {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get() {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }
}