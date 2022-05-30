namespace ChainOfResponsibility;

//interface Idetailing { }

//class Car
//{

//}

//class CarWash
//{
//    public Car CartoWash { get; set; }
//    public Idetailing Next { get; set; }

//    public Water Water { get; set; }
//    public Foam Foam { get; set; }
//    public Brush Brush { get; set; }
//}

//class Water : Idetailing
//{
//    private void Wash() => Console.WriteLine("Watering Car");
//    public uint Capacity { get; set; }
//    public Water()
//    {
//        Capacity = 5000; 
//        Wash();
//    }
//}

//class Foam : Idetailing
//{
//    public uint Capacity { get; set; }
//    public Foam() => Capacity = 2000;
//}

//class Brush : Idetailing
//{
//    public uint Strength { get; set; }
//    public Brush() => Strength = 10;
//}

public delegate bool SalaryHandler(float salary);
public delegate void IncomeHandler(string message);


public class Person
{
    private SalaryHandler? _salaryDelegate;
    private IncomeHandler? _incomeHandler;

    public event IncomeHandler? IncomeNotifier;

    public void RegisterHandlers(SalaryHandler? salaryHandler, IncomeHandler? incomeHandler)
    {
        _salaryDelegate = salaryHandler;
        _incomeHandler = incomeHandler;
        IncomeNotifier = _incomeHandler;
    }


    public string? Name { get; set; }

    private static readonly float Dvx = _salary * 0.05f;
    private const float Dsmf = 62.5f;
    private const float Itsda = 10f;
    private readonly float _taxes = Dvx + Dsmf + Itsda;

    private static float _salary;
    public float Salary
    {
        get => _salary;
        set
        {
            _salary = value;
            bool handlerResult;

            if (_salaryDelegate != null)
                handlerResult = _salaryDelegate.Invoke(_salary);
            else
                throw new NullReferenceException("SalaryDelegate is NULL...");


            if (handlerResult)
                _salary = value;
            else
                _salary += _taxes;

            IncomeNotifier?.Invoke($"Brutto salary: {_salary}" + "\n" +
                                   $"Netto salary: {_salary - _taxes}");


        }
    }


    internal static class Program
    {
        public static bool CheckIncome(float netto)
        {
            return netto >= 500 ? true : false;
        }

        public static void Main()
        {
            Person p1 = new();
            p1.RegisterHandlers(CheckIncome, message => Console.WriteLine(message));
            p1.Name = "Elvin";
            p1.Salary = 3200;


        }
    }
}