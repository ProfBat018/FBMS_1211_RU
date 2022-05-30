using System.Reflection.Metadata.Ecma335;

namespace DefaultDels
{
    internal static class Program
    {
        #region Action
        // public static void PrintMessage(string message) => Console.WriteLine(message);
        //
        // public static void PrintMessage2(string message, int count)
        // {
        //     for (int i = 0; i < count; i++)
        //         Console.WriteLine(message);
        // }
        //
        // public static void Main()
        // {
        //     // Always void delegate - Action
        //
        //     Action<string> action1 = PrintMessage;
        //     Action<string, int> action2 = PrintMessage2;
        //
        //     action1?.Invoke("123");
        //     action2?.Invoke("123", 5);
        // }
        #endregion

        #region Func
        // public static int Addition(int num1, int num2, int num3) => num1 + num2 + num3;
        //
        // public static float Division(int num1, int num2) => num1 / num2;
        //
        // public static void Main()
        // {
        //     // Functor
        //
        //     Func<int, int, int, int> func = Addition;
        //     Func<int, int, float> func2 = Division;
        //
        //     // Console.WriteLine(func2?.Invoke(3, 2));
        //     // Console.WriteLine(func?.Invoke(1, 2, 3));
        
        #endregion

        #region Predicate
        // public static bool IsEven(int number) => number % 2 == 0;
        //
        // public static void Main()
        // {
        //     Predicate<int> predicate = IsEven;
        //
        //     Console.WriteLine(predicate?.Invoke(6));
        // }
        #endregion

        public static bool PrintTest(int a)
        {
            Console.WriteLine("Test");
            return true;
        }
        public static void Main()
        {
            Func<int, bool> test = PrintTest;
            Predicate<int> a = PrintTest;
        }
    }    
}

