using Microsoft.AspNetCore.Mvc;

namespace OSUTEMP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] _summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var name= "Godarshan";

#pragma warning disable S125 // Sections of code should not be commented out
            if (true){
                Console.WriteLine("hello World");
                //Console.WriteLine(name);
            }
#pragma warning restore S125 // Sections of code should not be commented out

            Console.WriteLine(name);
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = _summaries[Random.Shared.Next(_summaries.Length)]
            })
            .ToArray();
        }
    }
}
