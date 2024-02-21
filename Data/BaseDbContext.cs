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
            optionsBuilder.UseSqlServer(connectionString: @"Server=YOUR_DATABASE_CONNECTION");
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
