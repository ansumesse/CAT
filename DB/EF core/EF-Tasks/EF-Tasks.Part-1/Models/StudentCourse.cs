﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class StudentCourse
    {
        public int St_Id { get; set; }
        public int C_Id { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
