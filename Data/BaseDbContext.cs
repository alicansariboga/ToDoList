using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Reflection;
using ToDoList.Models;

namespace ToDoList.Data
{
    public class BaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-4M0OQRD\SQLEXPRESS;Database=ToDoList;User Id=pixxaer;Password=453885;Encrypt=false;TrustServerCertificate=true;");
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
