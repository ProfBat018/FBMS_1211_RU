// Lock - Синтактический сахар, т.е обертка над монитором
// Monitor - Класс для синхронизации
// ManualResetEvent - Старый способ ручной синхронизации
// AutomaticResetEvent - Старый способ автомат. синхронизации
// Mutex - Способ синхронизации одиночного потока.
// Semaphore - Способ синхронизации несколько потоков.

// Над одними данными работает один поток.
// Проблема неактуальности информации.


//void foo(object i)
//{
//    object obj = new object();
//    lock (obj)
//    {
//        Console.WriteLine($"Id: {(int)i}\tThread: {Thread.CurrentThread.ManagedThreadId}");
//    }
//}

Semaphore Semaphore = new Semaphore(6, 6);

void Write(object i)
{
    Console.WriteLine($"Id: {i}\tThread: {Thread.CurrentThread.ManagedThreadId}");
    using FileStream fs = new("data.txt", FileMode.Append);
    using StreamWriter sw = new StreamWriter(fs);
    sw.Write((int)i);
}

void WriteForSemaphore()
{
    Semaphore.WaitOne();
    Console.WriteLine($"Writing... {Thread.CurrentThread.ManagedThreadId}");
    Semaphore.Release();
}

for (int i = 0; i < 5; i++)
{
    Thread thread = new Thread(WriteForSemaphore);
    thread.Start();
}


#region Mutex

//for (int i = 0; i < 2; i++)
//{
//    Mutex mutex = new Mutex(false);
//    Thread thread = new Thread(new ParameterizedThreadStart(Write));

//    try
//    {
//        if (mutex.WaitOne())
//        {
//            thread.Start(i);
//            Thread.Sleep(10);
//        }
//    }
//    finally
//    {
//        mutex.ReleaseMutex();
//    }
//}


#endregion