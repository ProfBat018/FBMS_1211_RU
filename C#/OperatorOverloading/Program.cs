using System;


namespace OperatorOverloading
{
    // public, private, protected, private protected, internal protected


    public class Modifiers
    {
        protected internal string Name { get; set; }

        public void foo()
        {
            Name = "fgdfg";
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            Modifiers mods = new Modifiers();
        }
    }
}

