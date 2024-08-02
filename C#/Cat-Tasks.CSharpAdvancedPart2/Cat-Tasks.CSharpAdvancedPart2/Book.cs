using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string? Publisher { get => publisher; set => publisher = value ?? default; }
        public int? PublishedYear { get => publishedYear; set => publishedYear = value ?? default; }
       
        private string? publisher;
        private int? publishedYear;
    }
}
