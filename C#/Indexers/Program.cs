namespace Indexers
{
    //class MyList
    //{
    //    public string[] Names { get; set; } = new[] { "1", "2", "3" };

    //    public string this[int index]
    //    {
    //        get => Names[index];
    //        set => Names[index] = value;
    //    }
    //}


    class MyList<T>
    {
        public T[] list { get; set; }

        public MyList(T[] values, int length)
        {

            list = new T[length];

            for (int i = 0; i < length; i++)
            {
                list[i] = values[i];
            }
        }

        public T this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            //MyList list = new MyList();

            //Console.WriteLine(list[2]);

            //MyList<int> list2 = new MyList<int>(new int[]{1, 2, 3, 4, 5}, 5);

            //Console.WriteLine(list2[3]);

            //list2[3] = 100;

            //Console.WriteLine(list2[3]);

            //unchecked
            //{

            //    int a = Int32.MaxValue;

            //    a++;

            //    Console.WriteLine(a);
            //}



        }
    }
}

