using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class ExpressionTrees_06
    {
        // Create a simple expression tree for a LINQ query.
        public static IEnumerable<Employee> EmpsSalaryGreaterThan(this IEnumerable<Employee> employees, decimal num) 
        {
            // emp.Salary > num
            ParameterExpression employeeExp = Expression.Parameter(typeof(Employee), "emps");
           
            var empSalaryExp = Expression.Property(employeeExp, "Salary");
           
            ConstantExpression numExp = Expression.Constant(num);
           
            BinaryExpression GreaterThan = Expression.GreaterThan(empSalaryExp, numExp);

            var filterExpr = Expression.Lambda<Func<Employee, bool>>(GreaterThan, employeeExp);

            return employees.Where(filterExpr.Compile());
        }
    }
}
