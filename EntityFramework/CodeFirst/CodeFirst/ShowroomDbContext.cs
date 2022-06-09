using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;


namespace CodeFirst
{
    public class ShowroomDbContext : DbContext
    {
        public ShowroomDbContext()
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-KNH15NM;Initial Catalog=Showroom;Integrated Security=True;");
        }
    }
}
