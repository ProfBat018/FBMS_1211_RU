namespace Records;

public record Person
{
    public string? Name { get; init; }
    public string? Surname { get; init; }
    public int Age { get; set; }
}


internal static class Program
{
    public static void Main()
    {
        Person p1 = new() { Name = "Elvin", Surname = "Azimov", Age = 20 };
        
        // Console.WriteLine($"{p1.Name} {p1.Surname} {p1.Age}");

        var a = Guid.NewGuid();            
        Console.WriteLine(a);
    }
}

