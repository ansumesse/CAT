using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class Instructor
    {
        
        public int Id { get; set; }
        // Use data annotations to mark specific columns as required in the database schema.
        //[Required]
        public string Name { get; set; }

        // Add a new entity class to the DbContext model and configure its mapping to the database.
        public List<Course> Courses { get; set; }
    }
}
