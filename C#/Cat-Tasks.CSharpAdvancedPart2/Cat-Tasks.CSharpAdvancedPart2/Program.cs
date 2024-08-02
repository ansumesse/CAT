namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library.AddBook(new Book() { ISBN = "133133" });
            Console.ReadKey();
        }
    }
}
