namespace Tasks.Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Employee = Repository.LoadEmployees();
            Console.WriteLine(Employee.GetFirstElement());
            Console.WriteLine(Employee.GetLastElement());
        }
    }
}
