namespace Files;

public class Person
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }
    public string? Email { get; set; }

    public override string ToString()
    {
        return $"Name is: {Name}\n" +
               $"Surname is: {Surname}\n" +
               $"Age is: {Age}\n" +
               $"Email is: {Email}\n";
    }
}
