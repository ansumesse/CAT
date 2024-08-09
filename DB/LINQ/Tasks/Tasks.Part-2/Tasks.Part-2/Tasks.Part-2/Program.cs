namespace Tasks.Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Employees = Repository.LoadEmployees();
            Console.WriteLine(Employees.GetFirstElement());
            Console.WriteLine(Employees.GetLastElement());

            var fiveEmps1 = new Employee[] {new Employee
                {
                        Id = 1001,
                        FirstName = "Cochran",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m
                }}; 
            var fiveEmps2 = new Employee[] {new Employee
                {
                        Id = 1001,
                        FirstName = "Cochran",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m
                }};
            Console.WriteLine(fiveEmps1.CheckIfEqual(fiveEmps2));

            var tenEmps = fiveEmps1.Concatenate(fiveEmps2);
            foreach (var item in tenEmps)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total Salary in IT = {Employees.SumEmpsSalaryWhere(x => x.Department == "IT"):N2}");
            Console.WriteLine($"Average Salary in IT = {Employees.AvgEmpsSalaryWhere(x => x.Department == "IT"):N2}");
            Console.WriteLine($"Max Salary in IT = {Employees.MaxEmpsSalaryWhere(x => x.Department == "IT"):N2}");

        }
    }
}
