using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class GroupingData_07
    {
        // Group a collection of objects by a common property using LINQ.
        public static IEnumerable<IGrouping<string, Employee>> GroupByDep(IEnumerable<Employee> employees)
        {
            var group = employees.GroupBy(x => x.Department);
            return group;
        }

        // Calculate aggregate functions (e.g., sum, average) on grouped data.
        public static IEnumerable<decimal> CalcTotalAndAvgSalary(IEnumerable<IGrouping<string, Employee>> departm, out List<decimal> AvgPerGro)
        {
            AvgPerGro = departm.Select(x => x.Average(y => y.Salary)).ToList();

            var TotalSalary = from dep in departm
                              select dep.Sum(x => x.Salary);
            return TotalSalary;
        }
    }
}
