using EF_Tasks.Part_2.Models;
using System.Globalization;

namespace EF_Tasks.Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            // var cust = context.Customers.Single(c => c.FirstName == "Anas");

            // var user = new User() { Email = "m@gmail.com" };
            // context.Users.Add(user);
            //var date = new DateOnly(2003, 2, 1);
            //var order = new Order() { CreatedOn = date };
            //context.Add(order);

            //context.SaveChanges();

            // -10- Retrieve all orders and find a specific order by ID using .Find
            //var orders = context.Orders.ToList();
            //foreach (var item in orders.Select(x => x.OrderId))
            //    Console.WriteLine(item);

            //var order = context.Orders.Find(5);
            //Console.WriteLine(order.OrderId + ", " + order.CreatedOn);

            // -11- Retrieve the first active product using .First
            var product = context.Products.First(x => x.IsActive);
            Console.WriteLine($"{product.ProductId} {product.ProductName}");
        }

    }
}
