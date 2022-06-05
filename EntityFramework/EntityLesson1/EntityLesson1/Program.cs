using System;
using System.Reflection.Metadata;
using EntityLesson1;
using EntityLesson1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

using AcademyContext context = new();

var teachers = context.Teachers.ToList();
var assistans = context.Assistants.ToList();

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



List<Teacher> b = new List<Teacher>(from i in teachers where i.Name == "Ilkin" select i);

b[0].Name = "Test";

context.SaveChanges();
