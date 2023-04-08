using contents.Models;
using Microsoft.AspNetCore.Mvc;

namespace contents.Controllers;

[ApiController]
[Route("")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public WelcomeMessage Get()
    {
        return new WelcomeMessage { Message = "Hello.  Welcome to the EF Assessment 'ExampleService' API." };
    }
}
