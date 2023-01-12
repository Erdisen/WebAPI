using Microsoft.AspNetCore.Mvc;

namespace _01_WebAPIGiris.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Celcius()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        //[HttpGet]
        //public string HavaDurumu(string isim)
        //{
        //    return $"Ho�geldin {isim} Bug�n hava  {Random.Shared.Next(-20,55)} derece. " ;
        //}

        [HttpGet]
        public string GetHavadurumu(int deger)

        {
            return $"Bug�n hava {deger} derece. ";
        }
        public string PostHavadurumu(int havasicakligi)
        {
            return "ok";
        }
    }
}