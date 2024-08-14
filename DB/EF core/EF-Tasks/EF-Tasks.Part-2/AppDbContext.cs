using EF_Tasks.Part_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_2
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFTask2;Integrated Security=True")
                .LogTo(Console.WriteLine, LogLevel.Information); // to Measure the performance improvement of queriesMeasure the performance improvement of queries
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // -1- Create an index on the CreatedAt column of the Orders table to optimize query performance.
            modelBuilder.Entity<Order>()
                .HasIndex(x => x.CreatedOn);

            // -2- Define a composite index on the FirstName and LastName columns of the Customers table.
            modelBuilder.Entity<Customer>()
                .HasIndex(x => new { x.FirstName, x.LastName });
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
