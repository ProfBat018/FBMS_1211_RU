using AzimEx.Models;
using Microsoft.EntityFrameworkCore;

namespace AzimEx.DbContexts
{
    public class UserDbContext : DbContext
    {
        public DbSet<UserViewModel>? Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder?.UseSqlServer("Data Source=WAYNE;Initial Catalog=AzimEx;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserViewModel>(entity =>
              {
                  entity.HasKey(x => x.Id);
                  entity.Property(x => x.Id).ValueGeneratedOnAdd();
                  entity.HasIndex(x => x.Email);
              });
        }
    }
}
