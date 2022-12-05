using Microsoft.EntityFrameworkCore;
using MyHottel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHottel.DBContext.ApplicationContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql("server=localhost;user=admin;password=123;database=usersdb;",
            //new MySqlServerVersion(new Version(10,4,27)));
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyHottel;Username=postgres;Password=123");
            //optionsBuilder.UseSqlite("Data Source=hottel.db");
        }
    }
}
