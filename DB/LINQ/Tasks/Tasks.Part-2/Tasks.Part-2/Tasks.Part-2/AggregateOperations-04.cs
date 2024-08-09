using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class AggregateOperations_04
    {
        // Implement LINQ queries to calculate sum, average, and maximum values from a collection.
        public static decimal SumEmpsSalaryWhere(this IEnumerable<Employee> emps, Func<Employee, bool> predicate) => emps.Where(predicate).Sum(x => x.Salary);
        public static decimal AvgEmpsSalaryWhere(this IEnumerable<Employee> emps, Func<Employee, bool> predicate) => emps.Where(predicate).Average(x => x.Salary);
        public static decimal MaxEmpsSalaryWhere(this IEnumerable<Employee> emps, Func<Employee, bool> predicate) => emps.Where(predicate).Max(x => x.Salary);
    }
}
