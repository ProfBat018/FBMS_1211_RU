using FluentApi;
using System;


using AcademyContext context = new();

var teachers = context.Teachers.Where(x => x.Id == 1);







