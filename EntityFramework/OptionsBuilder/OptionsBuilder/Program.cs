using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using OptionsBuilder;



var builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("Academy");

var optionsBuilder = new DbContextOptionsBuilder<AcademyContext>();

var options = optionsBuilder.UseSqlServer(connectionString).Options;

using AcademyContext context = new(options);


Console.WriteLine(context.Teachers.First().Name);
