using FunctionalProgramming;

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

            string Name = "MohAMmED";
            var UpperLtters = Name.UpperLetters();
            foreach (var item in UpperLtters)
            {
                Console.WriteLine(item);
            }

            var Employees = Repository.LoadEmployees();
            var EmpsFullName = ProjectionOperation_03.GetFullName(Employees);
            foreach (var item in EmpsFullName)
            {
                Console.WriteLine(item);
            }
            var Males = ProjectionOperation_03.GetMaleEmps(Employees);
            foreach (var item in Males)
            {
                Console.WriteLine(item);
            }

            var Sorted = SortingData_04.SortEmpsByDepAndSalary(Employees);
            foreach (var item in Sorted)
            {
                Console.WriteLine(item);
            }

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

            Console.WriteLine(Quantifiers_06.CheckAll(Employees));
            Console.WriteLine(Quantifiers_06.CheckAny(Employees));


        }
    }
}
