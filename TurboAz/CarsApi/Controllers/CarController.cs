using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        using FileStream fs = new("carsData.json", FileMode.OpenOrCreate);
        using StreamReader sr = new(fs);
        string json = sr.ReadToEnd();

        return Ok(json);
    }
}