namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Library.AddBook(new Book() { ISBN = "133133" });
            Library.Books.Add(new Book { Author = "ahmed",  PublishedYear = 2003, Publisher = "mof", Title = "nvv" });
            Library.Books.Add(new Book { Author = "ahmed", ISBN = "343", PublishedYear = 2003, Publisher = "mof", Title = "nvv" });
            Library.Books.Add(new Book { Author = "ahmed", ISBN = "343", PublishedYear = 2003, Publisher = "mof", Title = "nvv" });
            Library.Books.Add(new Book { Author = "ahmed", ISBN = "343", PublishedYear = 2003, Publisher = "mof", Title = "nvv" });
            Library.Books.Add(new Book { Author = "mohamed", ISBN = "343", PublishedYear = 2003, Publisher = "mof", Title = "nvv" });
            await Library.SaveBooks(Library.Books);
            await Library.LoadBooks();
            Console.ReadKey();
        }
    }
}
