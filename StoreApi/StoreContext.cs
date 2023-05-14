using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StoreApi
{
    public partial class StoreContext : DbContext
    {
        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BonusCard> BonusCards { get; set; } = null!;
        public virtual DbSet<BoughtProduct> BoughtProducts { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Receipt> Receipts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=1221.database.windows.net;Initial Catalog=Store;User ID=nightcall;Password=Elvin_123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonusCard>(entity =>
            {
                entity.ToTable("BonusCard");

                entity.Property(e => e.Balance)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((3))");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.BonusCards)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__BonusCard__Perso__797309D9");
            });

            modelBuilder.Entity<BoughtProduct>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BoughtProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__BoughtPro__Produ__503BEA1C");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasOne(d => d.Bonus)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.BonusId)
                    .HasConstraintName("FK__Customer__BonusI__04E4BC85");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Salary).HasColumnType("smallmoney");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Employee__Person__74AE54BC");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK__Employee__Positi__75A278F5");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.Id, "UQ__Product__3214EC06FBBB0B1D")
                    .IsUnique();

                entity.Property(e => e.ExpirationTime).HasColumnType("date");

                entity.Property(e => e.ProductionDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(dateadd(day,round(rand()*datediff(day,dateadd(day,(-500),getdate()),getdate()),(0)),dateadd(day,(-500),getdate())))");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .HasDefaultValueSql("(CONVERT([varbinary](max),newid()))");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.ToTable("Receipt");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.BoughtProducts)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.BoughtProductsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Receipt__BoughtP__55009F39");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
