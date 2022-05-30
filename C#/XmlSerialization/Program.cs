using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace XmlSerialization;

public enum Color { Red, Green, Blue, Yellow, Black, MidnightPurple, Azure, Lime }

[Serializable]
public class Car
{
    public Color CarColor { get; set; } = Color.MidnightPurple;
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
}

internal static class Program
{
    public static void Main()
    {
        #region XmlSerialization
        // using FileStream fs = new("data.xml", FileMode.OpenOrCreate);
        //
        // Car c1 = new()
        // {
        //     CarColor = Color.Black,
        //     Make = "Mercedes-Benz",
        //     Model = "E55 w212",
        //     Year = 2014
        // };
        //
        // Car c2 = new()
        // {
        //     CarColor = Color.MidnightPurple,
        //     Make = "Nissan",
        //     Model = "Skyline GTR r34",
        //     Year = 2002
        // };
        //
        // List<Car> cars = new() { c1, c2 };
        //
        // XmlSerializer xmlSerializer = new(typeof(List<Car>));
        //
        // xmlSerializer.Serialize(fs, cars);
        #endregion

        #region XmlDeSerialization

        // using FileStream fs = new("data.xml", FileMode.OpenOrCreate);
        //
        // XmlSerializer serializer = new(typeof(List<Car>));
        //
        // var cars = serializer.Deserialize(fs) as List<Car>;
        //
        // foreach (var car in cars)
        // {
        //     Console.WriteLine(car.CarColor);
        // }

        #endregion

        #region BinarySerialization

        using FileStream fs = new("data.bin", FileMode.OpenOrCreate);

        Car c1 = new()
        {
            CarColor = Color.Black,
            Make = "Mercedes-Benz",
            Model = "E55 w212",
            Year = 2014
        };

        BinaryFormatter formatter = new();
        
#pragma warning disable CS0618
        formatter.Serialize(fs, c1);
#pragma warning restore CS0618

        #endregion
    }
}
