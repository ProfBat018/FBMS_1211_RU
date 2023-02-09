using System.Text.Json;

namespace Serializing;

internal static class Program
{
    public static void Main()
    {
        // Serialization 

        using var fs = new FileStream("test.json", FileMode.OpenOrCreate);
        using var sr = new StreamReader(fs);

        string? result = sr.ReadToEnd();

        var anim1 = JsonSerializer.Deserialize<List<Animal>>(result);

        foreach (var animal in anim1)
        {
            Console.WriteLine(animal);
        }
    }
}

