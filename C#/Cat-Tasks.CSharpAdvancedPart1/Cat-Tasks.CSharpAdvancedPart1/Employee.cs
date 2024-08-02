using System;

namespace Cat_Tasks.CSharpAdvancedPart1
{
    public class Employee
    {
        public Employee(int iD, string name, int age, int totalSales, decimal salary) => (ID, Name, Age, TotalSales, Salary) = (iD, name, age, totalSales, salary);

        public Employee()
        {
        }

        // Normal delegete
        public delegate bool IsElligeble(Employee e);
        public delegate void SalaryChangedHandler(Employee e, decimal oldSalary);
        // event
        public event SalaryChangedHandler OnSalaryChanged;
        // Addition task Combine these concepts into a single task, such as creating a generic event handler using a lambda expression.
        public delegate void AnythingChangedHadler<in T, in T2>(T newValue, T2 oldValue); // Generic delegate 

        public event Action<Employee, string> OnEmployeeNameChanged; // event Using generic delegate that language support
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TotalSales { get; set; }
        public decimal Salary { get; set; }

        public void ChangeEmployeeNameTo(string newName)
        {
            var oldName = this.Name;
            this.Name = newName;
            if (OnEmployeeNameChanged != null)
                OnEmployeeNameChanged(this, oldName);
        }
        public  void ChangeSalaryTo(decimal newSalary)
        {
            decimal oldSalary = Salary;
            Salary = newSalary;
            if (OnSalaryChanged != null)
                OnSalaryChanged(this, oldSalary);
        }
        public override string ToString()
        {
            return $"\nID \t Name \t Age \t Total Sales \t Salary" +
                $"\n{ID} \t {Name} \t {Age} \t {TotalSales} \t {Salary}";
        }
        public static void EmployeeSales(MyList<Employee> emps, string title, Predicate<Employee> isElligeble) // Using generic delegate instead of normal delegate we intialized above
        {
            Console.WriteLine(title);

            foreach (var e in emps.Items)
            {
                if (isElligeble(e))
                    Console.WriteLine($"{e}");
            }
        }
    }
}
