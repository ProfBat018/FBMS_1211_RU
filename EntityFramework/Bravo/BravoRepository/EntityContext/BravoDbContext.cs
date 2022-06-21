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

        public DbSet<Cashiers> Cashiers { get; set; } = null!;
        public DbSet<Check> Check { get; set; } = null!;
        public DbSet<DateInfo> DateInfo { get; set; } = null!;
        public DbSet<Products> Products { get; set; } = null!;
        public DbSet<Stock> Stock { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BravoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
