using FunctionalProgramming;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks.Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = ints.PureFunc();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");

            string Name = "MohAMmED";
            var UpperLtters = Name.UpperLetters();
            foreach (var item in UpperLtters)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");

            var Employees = Repository.LoadEmployees();
            var EmpsFullName = ProjectionOperation_03.GetFullName(Employees);
            foreach (var item in EmpsFullName)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var Males = ProjectionOperation_03.GetMaleEmps(Employees);
            foreach (var item in Males)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");

            var Sorted = SortingData_04.SortEmpsByDepAndSalary(Employees);
            foreach (var item in Sorted)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var Chunks = DataPartitioning_05.Partition(Employees);
            int counter = 0;
            foreach (var chunk in Chunks)
            {
                Console.WriteLine($"partition[{++counter}]");
                foreach (var emp in chunk)
                {
                    Console.WriteLine(emp);
                }
            }
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine(Quantifiers_06.CheckAll(Employees));
            Console.WriteLine(Quantifiers_06.CheckAny(Employees));

            Console.WriteLine("------------------------------------------------------------------------");

            counter = 0;
            var Groups = GroupingData_07.GroupByDep(Employees);
            var TotalPerGroup = GroupingData_07.CalcTotalAndAvgSalary(Groups, out List<decimal> AvgPerGroup).ToList();
            foreach (var group in Groups)
            {
                Console.WriteLine(group.Key + $"\tTotal Salary: {TotalPerGroup[counter]}\tAverage Salary = {AvgPerGroup[counter++]:N2}");
                foreach (var emp in group)
                {
                    Console.WriteLine(emp);
                }
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var Departments = Repository.LoadDepartments();

            var Managernames = JoinOperations_08.GetDepManagerName(Employees, Departments);
            foreach (var item in Managernames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var ManagernamesL = JoinOperations_08.GetDepManagerNameEvenIfNull(Employees, Departments);
            foreach (var item in ManagernamesL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var Numbers = GenerationOperations_09.GetNums(1, 30);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            var Dates = GenerationOperations_09.GetDatesInRange(new DateTime(2003, 5, 1), new DateTime(2003, 5, 20));
            foreach (var item in Dates)
            {
                Console.WriteLine(item);
            }
        }
    }
}
