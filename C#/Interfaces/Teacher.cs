using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPerson
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }

        public void foo();

        public void bar()
        {
            Console.WriteLine("bar from interface");
        }
    }

    class Teacher : IPerson
    {
        public uint Salary { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }
        public void foo()
        {
            Console.WriteLine("Foo");
        }

        public void bar()
        {
            Console.WriteLine("bar from class");
        }
    }
}
