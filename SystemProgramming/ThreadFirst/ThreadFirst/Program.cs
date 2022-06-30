using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Console.WriteLine(Thread.CurrentThread.IsAlive);
// Console.WriteLine(Thread.CurrentThread.IsBackground);
// Console.WriteLine(Thread.CurrentThread.Priority);



namespace ThreadFirst
{
    internal class Program
    {
        public static object locker = new object();

        public static void Print()
        {
            lock (locker)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Hello: {i}");
                }
            }
        }

        public static void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"Thinks: {i}");
            }
        }

        static void Main(string[] args)
        {
            #region ThreadSleep

            // for (int i = 0; i < 5; i++)
            // {
            // Console.WriteLine("Hello");
            // Thread.Sleep(1000);
            // }

            // for (int i = 0; i < 5; i++)
            // {
            // Console.WriteLine("World");
            // Thread.Sleep(500);
            // }

            #endregion

            #region TwoThread

            //
            // Thread firstThread = new Thread(PrintHello);
            // Thread secondThread = new Thread(PrintBye);
            //
            //
            // void PrintHello()
            // {
            //     for (int i = 0; i < 5; i++)
            //     {
            //         Thread.Sleep(100);
            //         Console.WriteLine("Hello World");
            //     }
            // }
            //
            //
            // void PrintBye()
            // {
            //     for (int i = 0; i < 5; i++)
            //     {
            //         Thread.Sleep(100);
            //         Console.WriteLine("Bye World");
            //     }
            // }
            //
            //
            // firstThread.Start();
            // secondThread.Start();

            #endregion

            #region ThreaddLocking


            // for (int i = 0; i < 5; i++)
            // {
            //     Thread thread = new Thread(Print);
            //     Thread.Sleep(100);
            //     thread.Start();
            //     Console.WriteLine($"Id: {i}");
            // }



            #endregion

            #region Abort

            // for (int i = 0; i < 5; i++)
            // {
            //     Thread thread = new Thread(Print);
            //     Thread.Sleep(100);
            //     thread.Start();
            //     Console.WriteLine($"Id: {i}");
            //
            //     if (i == 3)
            //     {
            //         thread.Abort();
            //     }
            // }

            #endregion

            #region Suspend

            Thread thread = new Thread(Count);

            thread.Start();
            
            Thread.Sleep(1000);
            thread.Suspend();
            Console.WriteLine(thread.ThreadState);
            Thread.Sleep(5000);
            thread.Resume();
            Console.WriteLine(thread.ThreadState);
            #endregion
        }
    }
}
