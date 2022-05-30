using System.Threading.Channels;

namespace Delegates;


class Program
{
    #region Part1

    // public delegate void Mydelegate();
    //
    //
    // public static void foo()
    // {
    //     Console.WriteLine("Foo");
    // }
    //
    // public static void foo2()
    // {
    //     Console.WriteLine("Foo2");
    // }


    #endregion
   
    public static float FirstRankSalary(float netto)
    {
        return netto + 350;
    }

    public static float SecondRankSalary(float netto)
    {
        return netto + 150;
    }
    
    public static void PrintSalary(string message)
    {
        Console.WriteLine(message);
    }
    
    public static void Main()
    {
        #region Part1

        // Mydelegate mydelegate = foo;
        //
        // mydelegate.Invoke(); // mydelegate()
        //
        // mydelegate?.Invoke();
        //
        // if (mydelegate != null)
        // {
        //     mydelegate.Invoke();
        // }

        #endregion

        #region Part2
        //
        // Mydelegate del = foo;
        //
        // del += foo2;
        //
        // del?.Invoke();
        //
        // del -= foo;
        //
        // del?.Invoke();
            

        #endregion


        Worker person1 = new();
        
        person1.RegisterFuncs(FirstRankSalary, PrintSalary);
        person1.Name = "Elvin";
        person1.Salary = 3500;
        
        
        Worker person2 = new();
        
        person1.RegisterFuncs( SecondRankSalary, PrintSalary);
        person1.Name = "Ilkin";
        person1.Salary = 1400;
        
        
        
    }
}
