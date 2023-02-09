using System.Collections.ObjectModel;
using System.Net;
using System.Reflection;


namespace ConsoleApp1211
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Person person = new Person()
            {
                FirstName = "Elvin",
                LastName = "Azimov",
                Age = random.Next(1, 10)
            };
            Console.WriteLine(person);
        }
    }
}




//Teacher teacher = new Teacher(1, "Elvin", "Azimov", 20);

//Subject s1 = new Subject()
//{
//    Name = "Python",
//    Duration = 38,
//    Teacher = teacher,
//    t = teacher
//};