using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class JoinOperations_08
    {
        // Perform an inner join between two collections of objects using LINQ.

        public static IEnumerable<DepManagersNameDto> GetDepManagerName(IEnumerable<Employee> employees, IEnumerable<Department> departmenets)
        {
            var DepManagersName = from dep in departmenets
                                  join emp in employees
                                  on dep.ManagerId equals emp.Id
                                  select new DepManagersNameDto
                                  {
                                      DepartmentName = dep.Name,
                                      DepMangerName = $"{emp.FirstName} {emp.LastName}"
                                  };
            return DepManagersName;
        }

        // Implement a left join operation and handle null values in the result.
        public static IEnumerable<DepManagersNameDto> GetDepManagerNameEvenIfNull(IEnumerable<Employee> employees, IEnumerable<Department> departmenets)
        {
            var DepManagersName = from dep in departmenets
                                  join emp in employees on dep.ManagerId equals emp.Id into egroup
                                  from emp in egroup.DefaultIfEmpty()
                                  select new DepManagersNameDto
                                  {
                                      DepartmentName = dep.Name,
                                      DepMangerName = $"{emp?.FirstName ?? "Null"} {emp?.LastName ?? string.Empty}"
                                  };
            return DepManagersName;
        }
    }
}
