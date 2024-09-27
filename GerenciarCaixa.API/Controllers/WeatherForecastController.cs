using GerenciarCaixa.Domain.Entities;
using GerenciarCaixa.Persistence.Context;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarCaixa.API.Controllers
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
        private readonly MyContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult AdicionarMesa([FromBody] MesaDto mesaDto)
        {
             _context.Mesas.Add(Mesa.Criar(mesaDto.IdentificaMesa));
             _context.SaveChanges();
            return Ok();
        }
    }
}