using EF_Tasks.Part_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Create a new DbContext class and configure database connection strings in the application configuration file
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreLearning;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use fluent API to mark specific columns as required in the database schema.
            modelBuilder.Entity<Instructor>()
                .Property(x => x.Name)
                .IsRequired();

            /* // Prevent a specific entity from being included in the DbContext or migrations using configuration options
             modelBuilder.Ignore<Course>();

            modelBuilder.Entity<Course>()
                .ToTable("Courses", x => x.ExcludeFromMigrations());
            */

            /* // Customize the table name for an entity using fluent API.

             modelBuilder.Entity<Instructor>()
                             .ToTable("FullName");
             */
            /* // Customize the table name for an entity using fluent API.
             
            modelBuilder.Entity<Instructor>()
                            .ToTable("FullName", schema: "Training");
             */
            
        }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
