using EF_Tasks.Part_1.Migrations;
using EF_Tasks.Part_1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            // Ignore certain properties of an entity from being mapped to database columns using configuration options.
            // modelBuilder.Entity<Instructor>().Ignore(x => x.Courses);

            // Rename database columns for entity properties using data annotations or fluent API.
            modelBuilder.Entity<Course>()
                            .Property(x => x.CourseName)
                            .HasColumnName("CName");

            // Specify data types for database columns corresponding to entity properties.
            modelBuilder.Entity<Course>()
                .Property(x => x.CourseName)
                .HasColumnType("VARCHAR(50)");

            // Set maximum length constraints for string properties in the database schema.
            modelBuilder.Entity<Course>()
                .Property(x => x.CourseName)
                .HasMaxLength(100);

            // Add comments to database columns using data annotations or fluent API
            modelBuilder.Entity<Course>()
                .Property(x => x.CourseName)
                .HasComment("this a new comment");

            // Configure primary keys for entity classes using data annotations or fluent API.
            modelBuilder.Entity<Course>()
                .HasKey(x => x.Id);

            // Customize the name of the primary key column in the database schema
            modelBuilder.Entity<Course>()
                .HasKey(x => x.Id)
                .HasName("CourID");

            // Define composite keys using multiple properties of an entity class.
            //modelBuilder.Entity<Course>()
            //    .HasKey(x => new { x.Id, x.CourseName });

            // Specify default values for database columns using data annotations or fluent API.
            modelBuilder.Entity<Instructor>()
                .Property(x => x.RollDate)
                .HasDefaultValueSql("GETDATE()");

            // Configure computed columns in the database schema.
            modelBuilder.Entity<Instructor>()
                .Property(x => x.NameId)
                .HasComputedColumnSql("[NAME] + ', ' + [ID]");

            // Set default values for primary key columns using data annotations or fluent API.
            modelBuilder.Entity<Course>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            // Define one-to-one relationships between entity classes using data annotations or fluent API.
            modelBuilder.Entity<Instructor>()
                .HasOne<Instructor>()
                .WithOne();

            // Establish one - to - many relationships between entity classes using data annotations or fluent API.
            modelBuilder.Entity<Car>()
                .HasKey(x => x.LicensePlate);
            modelBuilder.Entity<Car>()
                .HasMany<Sale>()
                .WithOne()
                .HasForeignKey(x => x.LicensePlate);

            // Create many-to-many relationships between entity classes and configure the mapping table using data annotations or fluent API.

            modelBuilder.Entity<Student>()
                .HasKey(S => S.Sr_Id);
            modelBuilder.Entity<Student>()
            .HasMany<Course>()
            .WithMany()
            .UsingEntity(sc => sc.ToTable("StudentCourse"));


        }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
