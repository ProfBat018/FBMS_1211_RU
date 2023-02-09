// ASP.NET
// Laravel PHP
// Spring Java




using System.Reflection;
using System.Reflection.Metadata.Ecma335;

var p1 = new Person();

var props = typeof(Person).GetProperties();
var methods = typeof(Person).GetMethods();

foreach (PropertyInfo? prop in props)
{
    Console.WriteLine(
        $"Name: {prop.Name}\n" +
        $"Type: {prop.PropertyType.Name}\n" +
        $"Protected: {prop?.GetSetMethod()!.IsFamily}\n" +
        $"Public: {prop?.GetSetMethod()!.IsPublic}\n" +
        $"Private: {prop?.GetSetMethod()!.IsPrivate}\n");
}

var methodName = "Eat";


foreach (MethodInfo method in methods)
{
    if (method.Name == methodName)
    {
        method?.Invoke(p1, null);
    }
}
class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Person eats....");
    }
}