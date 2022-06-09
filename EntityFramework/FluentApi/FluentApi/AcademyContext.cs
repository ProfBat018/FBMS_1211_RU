using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FluentApi
{
    public partial class AcademyContext : DbContext
    {
        public AcademyContext()
        {
        }

        public AcademyContext(DbContextOptions<AcademyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assistant> Assistants { get; set; } = null!;
        public virtual DbSet<Curator> Curators { get; set; } = null!;
        public virtual DbSet<Dean> Deans { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Faculty> Faculties { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GroupsCurator> GroupsCurators { get; set; } = null!;
        public virtual DbSet<GroupsLecture> GroupsLectures { get; set; } = null!;
        public virtual DbSet<Head> Heads { get; set; } = null!;
        public virtual DbSet<Lecture> Lectures { get; set; } = null!;
        public virtual DbSet<LectureRoom> LectureRooms { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;
        public virtual DbSet<Subject> Subjects { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<Tutor> Tutors { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNH15NM;Initial Catalog=University;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Name)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(x => x.Surname)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Assistant>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Assistants)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Assistant__Teach__6477ECF3");
            });
        
            modelBuilder.Entity<Curator>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Curators)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Curators__Teache__656C112C");
            });
        
            modelBuilder.Entity<Dean>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Deans)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Deans__TeacherId__66603565");
            });
        
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Departme__737584F657FDF7AB")
                    .IsUnique();
        
                entity.Property(e => e.Name).HasMaxLength(100);
        
                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departmen__Facul__6754599E");
        
                entity.HasOne(d => d.Head)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.HeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Departmen__HeadI__68487DD7");
            });
        
            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Facultie__737584F69FEBEE82")
                    .IsUnique();
        
                entity.Property(e => e.Name).HasMaxLength(100);
        
                entity.HasOne(d => d.Dean)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.DeanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Faculties__DeanI__693CA210");
            });
        
            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Groups__737584F642D37032")
                    .IsUnique();
        
                entity.Property(e => e.Name).HasMaxLength(10);
        
                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Groups__Departme__6A30C649");
            });
        
            modelBuilder.Entity<GroupsCurator>(entity =>
            {
                entity.HasOne(d => d.Curator)
                    .WithMany(p => p.GroupsCurators)
                    .HasForeignKey(d => d.CuratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupsCur__Curat__6B24EA82");
        
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsCurators)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupsCur__Group__6C190EBB");
            });
        
            modelBuilder.Entity<GroupsLecture>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsLectures)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupsLec__Group__6D0D32F4");
        
                entity.HasOne(d => d.Lecture)
                    .WithMany(p => p.GroupsLectures)
                    .HasForeignKey(d => d.LectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GroupsLec__Lectu__6E01572D");
            });
        
            modelBuilder.Entity<Head>(entity =>
            {
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Heads)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Heads__TeacherId__6EF57B66");
            });
        
            modelBuilder.Entity<Lecture>(entity =>
            {
                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Lectures)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lectures__Subjec__6FE99F9F");
        
                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Lectures)
                    .HasForeignKey(d => d.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Lectures__Teache__70DDC3D8");
            });
        
            modelBuilder.Entity<LectureRoom>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__LectureR__737584F68C1FCA99")
                    .IsUnique();
        
                entity.Property(e => e.Name).HasMaxLength(10);
            });
        
            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasOne(d => d.Lecture)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.LectureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Schedules__Lectu__71D1E811");
        
                entity.HasOne(d => d.LectureRoom)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.LectureRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Schedules__Lectu__72C60C4A");
            });
        
            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasIndex(e => e.Name, "UQ__Subjects__737584F686705768")
                    .IsUnique();
        
                entity.Property(e => e.Name).HasMaxLength(100);
            });
        
            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Elvin");
                entity.Property(e => e.Id).HasColumnName("id");
            });
        
            modelBuilder.Entity<Tutor>(entity =>
            {
                entity.HasIndex(e => e.StaffId, "StaffId_UNIQUE_Constraint")
                    .IsUnique();
        
                entity.HasOne(d => d.Staff)
                    .WithOne(p => p.Tutor)
                    .HasForeignKey<Tutor>(d => d.StaffId)
                    .HasConstraintName("FK__Tutors__StaffId__33D4B598");
            });
        
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Login).HasMaxLength(15);
        
                entity.Property(e => e.Password)
                    .HasMaxLength(70)
                    .IsFixedLength();
            });
        
            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");
        
                entity.HasIndex(e => e.Name, "IX_Name");
        
                entity.HasIndex(e => e.Email, "UQ__Students__A9D10534CF9C2E4C")
                    .IsUnique();

                entity.Property(e => e.Age).HasDefaultValueSql("((18))");

                entity.Property(e => e.Email).HasMaxLength(30);
        
                entity.Property(e => e.Name).HasMaxLength(30);
        
                entity.Property(e => e.Surname).HasMaxLength(30);

            });
        
            OnModelCreatingPartial(modelBuilder);
        }




        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
