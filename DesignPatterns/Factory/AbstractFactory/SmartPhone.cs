namespace AbstractFactory;

class SmartPhone : IPhone
{
    public string CompanyName { get; set; }

    public void Answer()
    {
        Console.WriteLine("SmartPhone Answered");
    }

    public void Call()
    {
        Console.WriteLine("SmartPhone Called");
    }

    public void Decline()
    {
        Console.WriteLine("SmartPhone Declined");
    }
}
