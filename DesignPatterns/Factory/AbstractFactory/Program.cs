namespace AbstractFactory;

class Program
{
    public static void Main()
    {
        PhoneFactory factory = new LGFactory();   
    
        MobilePhone mobilePhone = factory.CreateMobilePhone();
        HomePhone homePhone = factory.CreateHomePhone();
        SmartPhone smartPhone = factory.CreateSmartPhone();

        Console.WriteLine(mobilePhone.CompanyName);
        mobilePhone.Answer();

        Console.WriteLine(homePhone.CompanyName);
        homePhone.Answer();

        Console.WriteLine(smartPhone.CompanyName);
        smartPhone.Answer();
    }
}