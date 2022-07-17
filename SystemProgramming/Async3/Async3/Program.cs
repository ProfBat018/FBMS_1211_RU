using System.Net;
using System.Text;


namespace TaskWaiting
{
    //class Program
    //{
    //    public static int id = 1;
    //    public static async Task<StringBuilder> GenRandomString()
    //    {
    //        var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    //        StringBuilder sb = new(id.ToString());
    //        id++;

    //        Random random = new();
    //        var length = random.Next(1, 20);

    //        for (int i = 0; i < length; i++)
    //        {
    //            sb.Append(chars[random.Next(chars.Length)]);
    //        }

    //        await Task.Delay(500);
    //        return sb;
    //    }

    //    public async static Task Main()
    //    {
    //        // var first = await GenRandomString();;
    //        // Console.WriteLine(first);
    //        // var second = await GenRandomString();;
    //        // Console.WriteLine(second);
    //        // var third = await GenRandomString();;
    //        // Console.WriteLine(third);


    //        //var first = GenRandomString(); 
    //        //var second = GenRandomString(); 
    //        //var third = GenRandomString();

    //        //await first;
    //        //await second;
    //        //await third;

    //        //Console.WriteLine(first.Result);
    //        //Console.WriteLine(second.Result);
    //        //Console.WriteLine(third.Result);

    //        #region WhenAll

    //        //var call = await Task.WhenAll(GenRandomString(), GenRandomString(), GenRandomString());

    //        //foreach (var item in call)
    //        //{
    //        //    Console.WriteLine(item);
    //        //}
    //        #endregion


    //        #region WhenAny

    //        // var call = await Task.WhenAny(GenRandomString(), GenRandomString(), GenRandomString());
    //        //
    //        // Console.WriteLine(call.Result);
    //        #endregion

    //    }
    //}

}

namespace IAsyncEnumerable1
{
    //class MyIntList : IAsyncEnumerable<int>
    //{
    //    public List<int> Nums { get; set; } = new();

    //    public MyIntList()
    //    {
    //        for (int i = 0; i < 15; i++)
    //        {
    //            Nums.Add(i + 1);
    //        }
    //    }

    //    public async IAsyncEnumerator<int> GetAsyncEnumerator(CancellationToken cancellationToken = new CancellationToken())
    //    {
    //        foreach (var item in Nums)
    //        {
    //            yield return item;
    //            await Task.Delay(500);
    //        }
    //    }
    //}

    //class Program
    //{
    //    public async static Task Main(string[] args)
    //    {
    //        MyIntList list = new();

    //        await foreach (var item in list)
    //        {
    //            Console.WriteLine(item);      
    //        }
    //    }
    //}
}

namespace IAsyncEnumerable2
{
 

    class Program
    {
        public static async IAsyncEnumerable<int> Foo()
        {
            var nums = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                nums.Add(i + 1);
            }

            foreach (var item in nums)
            {
                yield return item;
            }
        }

        public static async Task<int> Power(int number)
        {
            Console.Write("Power is working...\t");
            return number * number;
        }

        public static async Task Main(string[] args)
        {
            await foreach (var item in Foo())
            {
                Console.WriteLine(item);
                var res = Power(item);
                Console.WriteLine($"Power {item} in 2 = {res.Result}");
            }
        }
    }
}

