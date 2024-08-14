using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_2.Models
{
    internal class Customer
    {
        [Key]
        public int CoustomerId{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
