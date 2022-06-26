using Bravo.Services.Interfaces;
using BravoRepository.EntityContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
var builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile("appsettings.json");

var config = builder.Build();

string connectionString = config.GetConnectionString("Academy");

var optionsBuilder = new DbContextOptionsBuilder<AcademyContext>();

var options = optionsBuilder.UseSqlServer(connectionString).Options;

using AcademyContext context = new(options);

 */

namespace Bravo.Services.Classes
{
    internal class RepositoryData : IRepositoryData
    {
        public BravoDbContext GetContext()
        {
            var builder = new ConfigurationBuilder();

            builder.SetBasePath(Directory.GetCurrentDirectory());

            builder.AddJsonFile("Resources/Data/RepositoryConfig.json");

            var config = builder.Build();

            string connectionString = config.GetConnectionString("BravoDb");

            var optionsBuilder = new DbContextOptionsBuilder<BravoDbContext>();

            var options = optionsBuilder.UseSqlServer(connectionString).Options;

            using BravoDbContext context = new(options);

            return context;
        }
    }
}
