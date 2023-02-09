namespace Extensions;

/*
public static class StringExtension
{
    public static void Test(this string a)
    {
        Console.WriteLine(a + "Test");
    }
}
*/

public static class PersonExtension
{
    public static void PrintPerson(this Person p)
    {
        Console.WriteLine(p);
    }
}


internal static class Program
{
    public static void Main()
    {
        Person p1 = new() { Name = "Elvin", Surname = "Azimov", Age = 20 };
        
        p1.PrintPerson(); // PrintPerson(p1)
        
    }
}