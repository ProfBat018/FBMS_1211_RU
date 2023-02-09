using ASP_Auth.Models;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Xml;


namespace ASP_Auth.DbContexts
{
    public class AuthModelContext : DbContext
    {
        public DbSet<AuthModel>? Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder? optionsBuilder)
        {
            optionsBuilder?.UseSqlServer("Data Source=WAYNE;Initial Catalog=AspAuth;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder? modelBuilder)
        {
            modelBuilder?.Entity<AuthModel>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Id).ValueGeneratedOnAdd();
                entity.HasIndex(x => x.Email);
            });
        }
    }
}
