namespace Singleton;

public class MySingleton
{
    private static MySingleton? _instance;
    public string Name { get; set; }

    public static MySingleton GetInstance()
    {
        if (_instance == null)
            _instance = new MySingleton() { Name = "Hello"};
        return _instance;
    }
}


public class Program
{ 
    public static void Main()
    {
        var a = MySingleton.GetInstance();
        var b = MySingleton.GetInstance();
        var c = MySingleton.GetInstance();

        a.Name = "Elvin";

        Console.WriteLine(a.Name);
        Console.WriteLine(b.Name);
        Console.WriteLine(c.Name);

    }
}
