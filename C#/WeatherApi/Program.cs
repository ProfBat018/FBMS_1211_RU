using System.Net.Http.Headers;
using System.Text.Json;

namespace WeatherApi;

internal static class Program
{
    // https://api.openweathermap.org/data/2.5/weather?q=baku&appid=5191fee1957155f779bfd029a4a97e18

    public static Forecast? GetForecast(string cityName)
    {
        string? json = WeatherApiClient.SearchCity(cityName);

        var result = JsonSerializer.Deserialize<Forecast>(json);

        return result;
    }
    
    public static void Main()
    {
        Forecast? forecast = GetForecast("baku");

        if (forecast != null) Console.WriteLine(forecast.main.temp);
    }
}