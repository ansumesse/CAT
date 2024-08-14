using EF_Tasks.Part_2.Models;
using System.Globalization;

namespace EF_Tasks.Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            var cust = context.Customers.Single(c => c.FirstName == "Anas");
            
        }
        
}}
