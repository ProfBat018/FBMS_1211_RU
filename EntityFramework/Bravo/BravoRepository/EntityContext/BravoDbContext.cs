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

        public BravoDbContext(DbContextOptions<BravoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
