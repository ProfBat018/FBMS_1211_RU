namespace Delegates;

public delegate float SalaryDelegate(float num);
public delegate void IncomeDelegate(string message);

public class Worker
{
    public Worker()
    {
        
    }
    public Worker(string? name, float salary)
    {
        Salary = salary;
        Name = name;
    }
    
    private float CountSalary(float brutto)
    {
        float netto = brutto - (brutto * 0.05f);
        netto -= 62.5f;
        netto -= 10;
        return netto;
    }

    public void RegisterFuncs(SalaryDelegate? salaryDelegate, IncomeDelegate? incomeDelegate)
    {
        _salaryDel = salaryDelegate;
        _incomeDel = incomeDelegate;
        SalaryNotifier = _salaryDel;
        IncomeNotifier = _incomeDel;
    }
    
    public string? Name { get; set; }

    private SalaryDelegate? _salaryDel;
    private IncomeDelegate? _incomeDel;
    private event SalaryDelegate? SalaryNotifier;
    private event IncomeDelegate? IncomeNotifier;
    
    private float _salary;
    public float Salary
    {
        get
        {
            if (SalaryNotifier != null)
                return SalaryNotifier.Invoke(CountSalary(_salary));
            throw new NullReferenceException();
        }
        set
        {
            _salary = value;
            IncomeNotifier?.Invoke($"Your salary is: {_salary}");
        }
    }
}