
using System.ComponentModel;
using OperatorOverloading;

namespace Getters
{
    #region VirtualProperty
    /*
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public int Age { get; set; }
        public virtual string Id { get; set; }


        public virtual void foo()
        {
            Console.WriteLine("From Person...");
        }
    }

    class Student : Person
    {
        public uint GPA { get; set; }

        private string _id;
        public override string Id
        {
            get => _id;
            set => _id = "St" + value;
        }


        public override void foo()
        {
            Console.WriteLine("From Students...");
        }
    }
    */
    #endregion

    class Integer
    {
        public int Number { get; set; }

        public static Integer operator +(Integer i1, Integer i2)
        {
            return new Integer() { Number = i1.Number + i2.Number };
        }

        public override string ToString()
        {
            return $"{Number}";
        }
    }

    /*
    interface ISummable<T>
    {
        public T Sum(T t1, T t2);
    }


    class Integer<T> : ISummable<T>
    {
        public T Number { get; set; }

        public static Integer<T> operator +(Integer<T> i1, Integer<T> i2)
        {
            return new Integer<T>() { Number = i1.Number + i2.Number };
        }


        public override string ToString()
        {
            return $"{Number}";
        }
    }
    */

    class Program
    {
        public static void Main()
        {
            Integer integer1 = new Integer() { Number = 1 };
            Integer integer2 = new Integer() { Number = 4 };


            Console.WriteLine(integer1 + integer2);

        }
    }
}
