using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks.Part_1
{
    internal class Quantifiers_06
    {
        // Use quantifiers to check if all elements in a list satisfy a condition.

        public static bool CheckAll(IEnumerable<Employee> employees) => employees.All(x => x.Salary > 200_000);
        
        // Apply quantifiers to find if any element in a list meets a specific criteria.
        public static bool CheckAny(IEnumerable<Employee> employees) => employees.Any(x => x.Salary > 200_000);
    }
}
