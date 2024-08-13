using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class Student
    {
        public int Sr_Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}
