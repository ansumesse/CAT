using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_2.Models
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool IsActive { get; set; }
        // -8- Create a migration to add the DiscountPercentage column to the Products table.
        public double DiscountPercentage { get; set; }
    }
}
