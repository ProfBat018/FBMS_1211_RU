namespace AbstractFactory;

class MobilePhone : IPhone
{
    public string CompanyName { get; set; }

    public void Answer()
    {
        Console.WriteLine("Mobile Answered");
    }

    public void Call()
    {
        Console.WriteLine("Mobile Called");
    }

    public void Decline()
    {
        Console.WriteLine("Mobile Declined");
    }
}
