using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal class Library
    {
        public static List<Book> Books { get => books; set => books = value; }
        private static List<Book> books = new List<Book>();
        public static void AddBook(Book book)
        {
			try
			{
                if (book.ISBN.IsValidISBN())
                    Books.Add(book);
			}
			catch (Exception ex)
			{

                Console.WriteLine($"message: {ex.Message}");
            }
        }
        public async static Task SaveBooks(List<Book> books)
        {
            StringBuilder content = new StringBuilder();
            foreach (var book in books)
            {
                content.Append(book.ToString());

            }
            await File.WriteAllTextAsync("SaveToFileAsync", content.ToString());
        }
        public async static Task LoadBooks()
        {
            var path = "LoadFromFileAsync";
            if (File.Exists(path)) 
            {
                string content = await File.ReadAllTextAsync(path);
                Console.WriteLine(content);
            }

            
        }
    }
}
