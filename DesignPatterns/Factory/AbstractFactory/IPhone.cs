namespace AbstractFactory;

// Home Phone, Mobile Phone, Smart Phone  

interface IPhone
{
    public string CompanyName { get; set; }
    public void Call();
    public void Decline();
    public void Answer();
}
