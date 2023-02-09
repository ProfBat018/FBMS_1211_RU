using System.Net;
using System.Runtime.CompilerServices;

namespace Async;

internal class Program
{
    public static async Task foo()
    {
        Console.WriteLine("Foo starting async");
    }

    public static async Task foo2(object a)
    {
        Console.WriteLine("Foo2 starting async");
    }

    public static async Task Main()
    {
        Task task1 = new Task(() => foo());
        Task task2 = task1.ContinueWith(a => foo2(a));
        task1.Start();
        task2.Wait();
    }
}
