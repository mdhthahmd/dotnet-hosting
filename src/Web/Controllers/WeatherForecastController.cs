using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private static readonly string[] Icons = new[]
    {
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/clear-day.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/snow.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/partly-cloudy-day-haze.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/wind.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/thunderstorms-day-overcast-snow.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/solar-eclipse.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/overcast-day-fog.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/extreme.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/overcast-night-hail.svg", 
        "https://bmcdn.nl/assets/weather-icons/v3.0/fill/svg/hurricane.svg"
    };

    private readonly ILogger<WeatherController> _logger;

    public WeatherController(ILogger<WeatherController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 7).Select(index => new WeatherForecast
        {
            Id = index,
            Date = DateTime.Now.AddDays(index).ToString("MMMM dd yyyy, dddd"),
            Time = DateTime.Now.AddDays(index).ToString("HH:mm"),
            DateTime = DateTime.Now.AddDays(index).ToString(),
            Temperature= Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)],
            Image = Icons[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}