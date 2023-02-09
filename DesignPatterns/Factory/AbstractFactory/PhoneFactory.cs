namespace AbstractFactory;

interface PhoneFactory
{
    public HomePhone CreateHomePhone();
    public MobilePhone CreateMobilePhone();
    public SmartPhone CreateSmartPhone();
}
