using Adapter.Services.Classes;

namespace Adapter;



class Program
{
    public static void Main()
    {
        XMLAdapter<CityInfo> adapter = new XMLAdapter<CityInfo>();

        var result = adapter.ConvertToXml(CityInfoService.GetInfo("baku"));

        Console.WriteLine(result);
    }
}