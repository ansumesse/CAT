using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class ConvertingDataTypes_08
    {
        // Convert data types within LINQ queries using methods like Cast and OfType.
        public static IEnumerable<Employee> convertEmpsToManagerUsingCast(this IEnumerable<Employee> emps) => emps.Where(x => x.GetType() == typeof(Manager));
      
        
    }
}
