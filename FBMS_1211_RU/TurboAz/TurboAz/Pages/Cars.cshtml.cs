using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace TurboAz.Pages;

public class CarsData
{
    public CarModel[] Cars { get; set; }
}


public class CarModel
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Url { get; set; }
}


public class Cars : PageModel
{
    public CarsData Data { get; set; }
    public async Task OnGet()
    {
        HttpClient client = new();
        
        var res = await client.GetStringAsync(new Uri("https://localhost:3030/api/Car"));

        Data = JsonConvert.DeserializeObject<CarsData>(res);
    }
}