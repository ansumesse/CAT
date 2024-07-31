using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tasks.CSharpAdvancedPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Emps = new MyList<Employee>();
            Emps.Add(new Employee() { Age = 25, TotalSales = 140000, Name = "anas", ID = 10, Salary = 3000 });
            Emps.Add(new Employee() { Age = 26, TotalSales = 205000, Name = "Ahmed", ID = 11, Salary = 5999 });
            Emps.Add(new Employee() { Age = 27, TotalSales = 40400, Name = "Ali", ID = 12, Salary = 4988 });
            Emps.Print();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Employee.EmployeeSales(Emps, "greater than 50000", e => e.TotalSales > 50000); // Anonymos delegate using lambda experession
           
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
           
            Employee.EmployeeSales(Emps, "Between 50000 and 200000", e => e.TotalSales > 50000 && e.TotalSales < 200000);
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            Emps.Items[1].OnSalaryChanged += Emp_OnSalaryChanged;
            Emps.Items[1].ChangeSalaryTo(8000);
           
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
           
            Emps.Items[2].OnEmployeeNameChanged += Emp_OnEmployeeNameChanged;
            Emps.Items[2].ChangeEmployeeNameTo("Ibrahim");


            Console.ReadKey();
        }

        // Generic Event Handler
        private static void Emp_OnEmployeeNameChanged(Employee newValue, string oldValue)
        {
            if(newValue.Name != oldValue)
                Console.WriteLine($"{oldValue}\n change the name to {newValue}");
            else
                Console.WriteLine("nothing changed");
        }

        // Event handler
        private static void Emp_OnSalaryChanged(Employee e, decimal oldSalary)
        {
            if (e.Salary > oldSalary)
            {
                Console.WriteLine($"Congratus You got {e.Salary - oldSalary} bonus , Your Salary now is {e.Salary}");
            }
            else if(e.Salary< oldSalary)
            {
                Console.WriteLine($"YOu got a {oldSalary - e.Salary} deduction, Your Salary now is {e.Salary}");
            }
        }
    }
}
