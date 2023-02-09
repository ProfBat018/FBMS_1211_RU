using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace PLINQ;
#region AsyncPart3

class Program
{
    public static async Task<StringBuilder> Foo()
    {
        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        StringBuilder sb = new();

        Random random = new();
        var length = random.Next(1, 20);

        for (int i = 0; i < length; i++)
        {
            sb.Append(chars[random.Next(chars.Length)]);
        }

        await Task.Delay(2000);
        return sb;
    }

    public static int Square(int number, int power)
    {
        int res = 1;
        for (int i = 0; i < power; i++)
        {
            res *= number;
        }
        return res;
    }
    public static async Task Main()
    {
        #region Variant1

        // var result1 = await Foo();
        // Console.WriteLine(result1);
        // var result2 = await Foo();
        // Console.WriteLine(result2);
        // var result3 = await Foo();
        // Console.WriteLine(result3);

        #endregion

        #region Variant2
        // var res1 = Foo();
        // var res2 = Foo();
        // var res3 = Foo();

        // await res1;
        // await res2;
        // await res3;

        // Console.WriteLine(res1.Result);
        // Console.WriteLine(res2.Result);
        // Console.WriteLine(res3.Result);
        #endregion

        #region Variant3

        // var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, };

        // var result = list.AsParallel().Select(x => x * x * x);

        // foreach (var num in result)
        // {
        // Console.WriteLine(num);
        // }
        #endregion

        #region Variant4

        // var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, };

        //var result = list.AsParallel().Select(x => Square(x, 4));

        // foreach (var num in result)
        // {
        // Console.WriteLine(num);   
        // }

        #endregion

        string number = "+994-77-325-10-18";
        var expression = new Regex(@"^\(?[\+]?994[-]?([1-9]{2})\)?[-. ]?([1-9]{3})[-. ]?([0-9]{2})[-.]?([0-9]{2})$");

        Console.WriteLine(expression.IsMatch(number));

    }
}
#endregion
