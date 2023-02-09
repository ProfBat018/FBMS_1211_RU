using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShowroomRepository.Model;

namespace ShowroomRepository.DbContexts;

public partial class ShowroomContext : DbContext
{
    public ShowroomContext() : base()
    {
    }

    public ShowroomContext(DbContextOptions<ShowroomContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Salesman> Salesmen { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=WAYNE;Initial Catalog=Showroom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC07EE581287");

            entity.Property(e => e.Make).HasMaxLength(30);
            entity.Property(e => e.Model).HasMaxLength(30);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC071855858D");

            entity.HasOne(d => d.Person).WithMany(p => p.Customers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Customers__Perso__2A4B4B5E");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Person__3214EC077DF8E048");

            entity.ToTable("Person");

            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Surname).HasMaxLength(30);
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sales__3214EC071858948D");

            entity.HasOne(d => d.Car).WithMany(p => p.Sales)
                .HasForeignKey(d => d.CarId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__CarId__33D4B598");

            entity.HasOne(d => d.Person).WithMany(p => p.Sales)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__PersonId__34C8D9D1");

            entity.HasOne(d => d.Salesman).WithMany(p => p.Sales)
                .HasForeignKey(d => d.SalesmanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__SalesmanI__32E0915F");
        });

        modelBuilder.Entity<Salesman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Salesman__3214EC07672ADA6E");

            entity.ToTable("Salesman");

            entity.HasOne(d => d.Person).WithMany(p => p.Salesmen)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Salesman__Person__300424B4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
