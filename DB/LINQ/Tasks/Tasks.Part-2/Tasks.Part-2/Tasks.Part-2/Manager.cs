using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    internal class Manager: Employee
    {
        public decimal Bouns { get; set; }
        public override decimal Salary { get => base.Salary; set => base.Salary = value + Bouns; }
        public override string ToString()
        {
            return base.ToString()
                + $"\t{Bouns}";
        }
    }
}
