using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolLesson
{
    internal class Program
    {
        static CountdownEvent CountdownEvent = new CountdownEvent(10);
        static void Foo(object index)
        {
            Console.WriteLine($"Foo Started: {Thread.CurrentThread.IsThreadPoolThread}\t{Thread.CurrentThread.ManagedThreadId}\t {Thread.CurrentThread.IsBackground}");
            Thread.Sleep(100);
        }


        static void ThreadExample()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(Foo);
                thread.Start(i);
            }
        }

        static void ThreadPoolExample()
        {
            var operation = 100;

            using (var countdown = new CountdownEvent(operation))
            {
                for (int i = 0; i < operation; i++)
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(param =>
                    {
                        Console.WriteLine($"Foo Started: {Thread.CurrentThread.IsThreadPoolThread}\t{Thread.CurrentThread.ManagedThreadId}\t {Thread.CurrentThread.IsBackground}");
                        Thread.Sleep(100);
                        countdown.Signal();
                    }));
                }
                countdown.Wait();
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            ThreadExample();
            stopwatch.Stop();

            var a = stopwatch.Elapsed;
            stopwatch.Reset();

            stopwatch.Start();
            ThreadPoolExample();
            stopwatch.Stop();
            var b = stopwatch.Elapsed;
            stopwatch.Reset();

            Thread.Sleep(10);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
