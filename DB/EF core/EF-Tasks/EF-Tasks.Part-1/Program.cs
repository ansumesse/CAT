using EF_Tasks.Part_1.Models;

namespace EF_Tasks.Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            // Write code to insert new records into the database using Entity Framework.
            var instructor1 = new Instructor() { Name = "Anas" };
            context.Instructors.Add(instructor1);
            context.SaveChanges();
        }
    }
}
