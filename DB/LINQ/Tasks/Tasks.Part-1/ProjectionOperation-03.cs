using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal  class ProjectionOperation_03
    {
        // Create a LINQ query to project specific properties of objects in a collection.
        public static List<string> GetFullName( IEnumerable<Employee> employees)
        {
            var fullName = from emp in employees
                           select $"{emp.FirstName} {emp.LastName}";
            return fullName.ToList();
        }

        // Apply a projection operation to format data for display in a UI.
        public static IEnumerable<Employee> GetMaleEmps(IEnumerable<Employee> employees)
        {
            var MaleEmps = from emp in employees
                           where emp.Gender == "male"
                           select emp;
            return MaleEmps;
        }


    }
}
