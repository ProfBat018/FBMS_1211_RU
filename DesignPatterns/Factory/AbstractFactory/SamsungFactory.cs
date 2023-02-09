namespace AbstractFactory;

class SamsungFactory : PhoneFactory
{
    public HomePhone CreateHomePhone()
    {
        return new HomePhone() {  CompanyName = "Samsung"};
    }

    public MobilePhone CreateMobilePhone()
    {
        return new MobilePhone() { CompanyName = "Samsung" };
    }

    public SmartPhone CreateSmartPhone()
    {
        return new SmartPhone() { CompanyName = "Samsung" };
    }
}
