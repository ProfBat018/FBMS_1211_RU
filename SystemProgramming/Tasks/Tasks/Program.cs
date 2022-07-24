#region Action in ctor

//Task Task = new(() => Console.WriteLine("Hello World"));
//Task.Start();
//Thread.Sleep(1);

#endregion

#region TaskRun

//void foo()
//{
//    Console.WriteLine("fdsgfd");
//}

//Task.Run(foo);


#endregion

#region TaskFactoryStartNew

//void foo()
//{
//    Console.WriteLine("Hello");
//}

//Task.Factory.StartNew(foo);

#endregion


//Task task = new(
//    () =>
//    {
//        Console.WriteLine("Hello");
//        Task new_task = new(() => Console.WriteLine("World"));
//        Thread.Sleep(1);
//        new_task.Start();
//    });


//task.Start();
//Thread.Sleep(1);

#region IncludedExampleWithFactory

//Console.WriteLine("Before Task");

//var first = Task.Factory.StartNew(
//    () =>
//    {
//        Console.WriteLine("First Begins");
//        Task.Factory.StartNew(() =>
//        {
//            Console.WriteLine("Second Begins");
//            Thread.Sleep(1000);
//            Console.WriteLine("Second Ends");
//        }, TaskCreationOptions.AttachedToParent);
//        Console.WriteLine("First Ends");
//    });

//first.Wait();

#endregion

#region IncludedExampleWithClass

//Console.WriteLine("Before Task");

//Task Task = new(() =>
//    {
//        Console.WriteLine("First Begins");
//        Task second = new(() =>
//        {
//            Console.WriteLine("Second Begins");
//            Thread.Sleep(1000);
//            Console.WriteLine("Second Ends");
//        }, TaskCreationOptions.AttachedToParent);
//        second.Start();
//        Console.WriteLine("First Ends");
//    });
//Task.Start();
//Task.Wait();

#endregion


Task Task 