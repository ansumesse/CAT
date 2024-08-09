using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class SetsOperations_05
    {
        // Perform set operations (union, intersection, difference) on two sequences using LINQ methods.
        public static IEnumerable<Employee> UnionTwoEmps(this IEnumerable<Employee> emp1, IEnumerable<Employee> emp2) => emp1.Union(emp2);
        public static IEnumerable<Employee> IntersectTwoEmps(this IEnumerable<Employee> emp1, IEnumerable<Employee> emp2) => emp1.IntersectBy(emp2.Select(x => x.Id), x => x.Id);
        public static IEnumerable<Employee> ExceptTwoEmps(this IEnumerable<Employee> emp1, IEnumerable<Employee> emp2) => emp1.Except(emp2);

    }
}
