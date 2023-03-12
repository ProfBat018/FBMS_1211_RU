using DotNetAzWebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAzWebApi.Data.DbContexts;

public class DotNetAzDbContext : DbContext
{
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    
    public DotNetAzDbContext()
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=WAYNE;Initial Catalog=DOTNETAZ;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chapter>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Theme>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<Theme>()
            .HasOne(x => x.Chapter)
            .WithMany(x => x.Themes);

        base.OnModelCreating(modelBuilder);
    }
}