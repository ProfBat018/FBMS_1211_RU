using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using EntityLesson1;
using EntityLesson1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;


#region Lesson1

// using AcademyContext context = new();

// var teachers = context.Teachers.ToList();
// var assistans = context.Assistants.ToList();

// var new_teacher = new Teacher()
// {
//     Name = "NewOrxan",
//     Surname = "NewTukanov"
// };
//
// var new_assistant = new Assistant()
// {
//     Teacher = new_teacher
// };
//
// context.Teachers.Add(new_teacher);
// context.Assistants.Add(new_assistant);
//
// teachers[0].Name = "Kerim";
// teachers[0].Surname = "Kalashov";




// var cols = typeof(Teacher).GetProperties();
//
// foreach (var prop in cols)
// {
//     Console.Write(prop.Name + '\t');
// }


// foreach (var item in teachers)
// {
// Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");   
// }


// var t = teachers.First(x => x.Name == "NewElvin");
//
// context.Teachers.Remove(t);
// context.SaveChanges();



// var a = teachers.Where(x => x.Name.Contains("New")).ToList();
// context.SaveChanges();



// Console.WriteLine(teachers[0].Name);
// List<Teacher> b = new List<Teacher>(from i in teachers where i.Name == "Ilkin" select i);
//
// b[0].Name = "Test";

// context.SaveChanges();

#endregion


#region Includes
//
// using AcademyContext context = new();
//
// var lectures = context.GroupsLectures
//     .Include(x => x.Group)
//     .ThenInclude(x => x.Department)
//     .ThenInclude(x => x.Faculty)
//     .Include(x => x.Lecture)
//     .ThenInclude(x => x.Teacher).ToList();
//     
//
//
// foreach (var item in lectures)
// {
//     Console.WriteLine($"{item.Id}: {item.Group.Name},\t{item.Group.Department.Name}");
// }


#endregion


//using AcademyContext context = new();
//var props = context.GetType().GetProperties().ToList();

//List<PropertyInfo> data = new();


//foreach (var item in props)
//{
//    if (item.PropertyType.ToString().Contains("DbSet"))
//    {
//        data.Add(item);
//    }
//}


#region Lazy

// using AcademyContext context = new();
//
//
// var assistants = context.Assistants.ToList();
//
//
// foreach (var item in assistants)
// {
//     Console.WriteLine(item.Id.ToString() + '\t' + item.Teacher.Name);
// }

#endregion

#region Eager


// using AcademyContext context = new();
//
// var assistants = context.Assistants.Include(x => x.Teacher).ToList();
//
// foreach (var item in assistants)
// {
//     Console.WriteLine(item.Id.ToString() + '\t' + item.Teacher.Name);
// }


#endregion


#region Explicit


using AcademyContext context = new();

var data = context.Assistants.First();
var collection = context.Assistants.ToList();

// context.Entry(data).Reference(x=> x.Teacher).Load();

Console.WriteLine(data.Teacher.Name);


#endregion
