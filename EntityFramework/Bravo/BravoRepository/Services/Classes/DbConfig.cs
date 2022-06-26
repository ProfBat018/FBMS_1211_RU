using BravoRepository.EntityContext;
using BravoRepository.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BravoRepository.Services.Classes
{
    public class DbConfig : IDbConfig
    {
        public BravoDbContext ConnectTo(string? dbName)
        {
            var builder = new ConfigurationBuilder();
            var optionsBuilder = new DbContextOptionsBuilder<BravoDbContext>();
            
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("Resources/Data/RepositoryConfig.json");

            var config = builder.Build();
            var options = optionsBuilder.UseSqlServer(config.GetConnectionString(dbName)).Options;
            
            return new BravoDbContext(options);
        }
    }
}
