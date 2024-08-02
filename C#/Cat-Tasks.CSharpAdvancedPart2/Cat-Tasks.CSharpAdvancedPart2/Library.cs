using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal class Library
    {
        public static void AddBook(Book book)
        {
			try
			{
				book.ISBN.IsValidISBN();
			}
			catch (Exception ex)
			{

                Console.WriteLine($"message: {ex.Message}");
            }
        }
    }
}
