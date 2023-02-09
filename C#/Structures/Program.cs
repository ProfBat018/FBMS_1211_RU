namespace Structures
{
    struct MyStruct
    {
        public MyStruct(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }

    
    class Program
    {
        public static void Main()
        {
            MyStruct a = new MyStruct("Elvin");

            Console.WriteLine(a.Name);
        }
    }
}