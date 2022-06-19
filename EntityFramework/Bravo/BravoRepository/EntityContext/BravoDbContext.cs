using BravoRepository.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BravoRepository.EntityContext
{
    public class BravoDbContext : DbContext
    {
   
        public DbSet<Cashiers> Cashiers { get; set; }
        public DbSet<Check> Check { get; set; }
        public DbSet<DateInfo> DateInfo { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Stock> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BravoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
