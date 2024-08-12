using EF_Core_Tasks.Part_1.Models;
using System.ComponentModel;

namespace EF_Core_Tasks.Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write code to insert new records into the database using Entity Framework.
            var context = new AppDbContext();
            var Employee1 = new Employee() { Name = "Mohamed" };
            context.Employees.Add(Employee1);
            context.SaveChanges();
        }
    }
}
