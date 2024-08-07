using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class DepManagersNameDto
    {
        public string DepartmentName { get; set; }
        public string DepMangerName { get; set; }
        public override string ToString()
        {
            return $"Department: {DepartmentName}\t\tManager: {DepMangerName}";
        }
    }
}
