using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tasks.Part_2.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public DateOnly CreatedOn { get; set; }
    }
}
