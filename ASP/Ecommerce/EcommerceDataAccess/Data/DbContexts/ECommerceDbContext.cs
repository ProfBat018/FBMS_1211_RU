using Ecommerce.Data.Models;
using EcommerceDataAccess.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Data.DbContexts
{
    public class ECommerceDbContext : IdentityDbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<CoverType> CoverTypes{ get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            
            builder.AddJsonFile("appsettings.json", reloadOnChange: true, optional:false);

            var config = builder.Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("EcommerceDbRemote"));

            base.OnConfiguring(optionsBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<CoverType>()
              .HasKey(x => x.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
