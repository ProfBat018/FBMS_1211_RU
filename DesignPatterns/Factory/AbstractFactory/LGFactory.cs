namespace AbstractFactory;

class LGFactory : PhoneFactory
{
    public HomePhone CreateHomePhone()
    {
        return new HomePhone() { CompanyName = "LG" };
    }

    public MobilePhone CreateMobilePhone() 
    {
        return new MobilePhone() {  CompanyName = "LG"};
    }

    public SmartPhone CreateSmartPhone()
    {
        return new SmartPhone() {  CompanyName = "LG"};
    }
}
