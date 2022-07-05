using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSecond
{
    internal class Program
    {
        #region locker
        //static void PrintObj(object obj)
        //{
        //    object locker = new object();

        //    lock (locker)
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine($"Thread step: {i}");
        //        }
        //    }
        //}
        #endregion

        static object locker = new object();

        #region Monitor
        static void PrintObj(object obj)
        {
            bool IsLocked = false;
            locker = "fdglohkdmfgih";

            Monitor.TryEnter(locker, ref IsLocked);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread step: {i}");
            }
            if (IsLocked)
            {
                Monitor.Exit(locker);
            }

        }
        #endregion
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(PrintObj);
                Thread.Sleep(100);
                thread.Start(i.ToString());
                Console.WriteLine($"Thread id: {i}");
            }

        }
    }
}
