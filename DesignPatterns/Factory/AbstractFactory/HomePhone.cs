namespace AbstractFactory;

class HomePhone : IPhone
{
    public string CompanyName { get; set; }

    public void Answer()
    {
        Console.WriteLine("Home phone answered");
    }

    public void Call()
    {
        Console.WriteLine("Home phone Called");

    }

    public void Decline()
    {
        Console.WriteLine("Home phone Declined");

    }
}
