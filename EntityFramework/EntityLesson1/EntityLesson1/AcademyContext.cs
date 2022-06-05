using System;
using System.Collections.Generic;
using EntityLesson1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityLesson1
{
    public partial class AcademyContext : DbContext
    {
        public AcademyContext()
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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNH15NM;Initial Catalog=Academy;Integrated Security=True;");
            }
        }
    }
}
