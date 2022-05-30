using System.Collections;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
namespace Iterators;

internal static class Program
{
    public static  void Main()
    {
        var list = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }
        
        var query = from i in list
                    where i % 2 == 0
                    select i;

    
        
        foreach (var i in query)
        {
            Console.WriteLine(i);
        }
        
        
        var query2 = list.Where(i => i % 2 == 0).Select(i => i);
        
    }
}