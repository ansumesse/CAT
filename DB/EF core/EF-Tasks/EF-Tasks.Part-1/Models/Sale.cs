using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_1.Models
{
    internal class Sale
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public decimal Price { get; set; }
    }
}
