using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class Course
    {
        // Configure primary keys for entity classes using data annotations or fluent API.
        // Set default values for primary key columns using data annotations or fluent API.
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Rename database columns for entity properties using data annotations 
        // [Column("CName")]
        // Specify data types for database columns corresponding to entity properties.
        //[Column(TypeName = "VARCHAR(50)")]
        // Set maximum length constraints for string properties in the database schema.
        // Add comments to database columns using data annotations or fluent API
        [MaxLength(100), Comment("THis is a column comment")]
        public string CourseName { get; set; }
        public List<StudentCourse> studentCourses { get; set; }

    }
}
