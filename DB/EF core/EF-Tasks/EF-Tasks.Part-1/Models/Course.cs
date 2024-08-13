using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class Course
    {
        public int Id { get; set; }
        // Rename database columns for entity properties using data annotations 
        [Column("CName")] 
        public string CourseName { get; set; }

    }
}
