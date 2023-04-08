using contents.Models;
using Microsoft.AspNetCore.Mvc;

namespace contents.Controllers;

[ApiController]
[Route("")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public WelcomeMessages Get()
    {
        var msgs = new WelcomeMessages();
        msgs.Messages.Add("Hello.");
        msgs.Messages.Add("Welcome to the EF Assessment 'ExampleService' API.");
        return msgs;
    }
}
