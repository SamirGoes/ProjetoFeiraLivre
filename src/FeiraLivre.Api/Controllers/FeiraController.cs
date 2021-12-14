using Microsoft.AspNetCore.Mvc;
using FeiraLivre.Api.Models;

namespace FeiraLivre.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FeiraController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    public FeiraController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetFeiras")]
    public IEnumerable<Feira> Get()
    {
        return Enumerable.Empty<Feira>();
    }

    [HttpPost(Name="CreateData")]
    public void LoadFeiraDb()
    {
        
    }
}


