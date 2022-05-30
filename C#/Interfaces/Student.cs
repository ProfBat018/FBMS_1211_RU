using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }

        protected Person(string name, string surname, uint age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }

    class Student : Person
    {
        public uint GPA { get; set; }

        public Student(string name, string surname, uint age, uint gpa)
            : base(name, surname, age)
        {
            GPA = gpa;
        }
    }
}
