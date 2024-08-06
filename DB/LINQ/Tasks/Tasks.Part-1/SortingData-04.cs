using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class SortingData_04
    {
        // Implement sorting of a list of objects based on different properties using LINQ.
        public static IEnumerable<Employee> SortEmpsByDepAndSalary(IEnumerable<Employee> employees)
        {
            //var sortedEmps = from emp in employees
            //                 orderby (emp.Department, emp.Salary)
            //                 select emp;

            var sortedEmps = employees.OrderBy(x => x.Department).ThenBy(x => x.Salary);

            return sortedEmps;
        }
    }
}
