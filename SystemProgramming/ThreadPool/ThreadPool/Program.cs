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
        static void Foo(object index)
        {
            Console.WriteLine($"Foo Started: {Thread.CurrentThread.IsThreadPoolThread}\t{Thread.CurrentThread.ManagedThreadId}\t {Thread.CurrentThread.IsBackground}");
        }


        static void ThreadExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Foo);
                thread.Start(i);
            }
        }

        static void ThreadPoolExample()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(param => Foo(i)));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Process.GetCurrentProcess().Threads.Count);

            ProcessThreadCollection thread_count = Process.GetCurrentProcess().Threads;

            foreach (ProcessThread item in thread_count)
            {
                Console.WriteLine(item.ThreadState);
            }

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

            Thread.Sleep(1000);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(Process.GetCurrentProcess().Threads.Count);

            thread_count = Process.GetCurrentProcess().Threads;
            foreach (ProcessThread item in thread_count)
            {
                Console.WriteLine(item.ThreadState);
            }
        }
    }
}
