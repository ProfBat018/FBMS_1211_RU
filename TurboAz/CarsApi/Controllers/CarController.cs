using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

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

    [HttpPost]
    public IActionResult Addcar(string make, string model, string url)
    {
        Car car = new()
        {
            Make = make,
            Model = model,
            Url = url
        };

        using FileStream fs = new("carsData.json", FileMode.OpenOrCreate);
        using StreamReader sr = new(fs);

        string json = sr.ReadToEnd();

        CarsData cars = JsonSerializer.Deserialize<CarsData>(json);

        cars.Cars.Add(car);

        fs.Close();

        using FileStream fs2 = new ("carsData.json", FileMode.Truncate);
        
        string newJson = JsonSerializer.Serialize(cars);

        using StreamWriter sw = new(fs);

        sw.Write(newJson);
        
        return Ok(json);
    }
}