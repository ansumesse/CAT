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
        }
    }
}
