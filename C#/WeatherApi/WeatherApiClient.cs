using System.Net;

namespace WeatherApi;
public static class WeatherApiClient
{
    private const string? Key = "5191fee1957155f779bfd029a4a97e18";
    public static string SearchCity(string cityName)
    {
        var client = new WebClient();
        
        var link = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={Key}&units=metric";

        string? result = client.DownloadString(link);

        return result;
    }
}