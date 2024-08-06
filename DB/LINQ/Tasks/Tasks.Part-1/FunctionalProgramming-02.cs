using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal static class FunctionalProgramming
    {
        // Rewrite an existing LINQ query using a functional programming approach.
        // returns only capital litters
        public static List<char> UpperLetters(this string word) 
        {
            // LINQ Query
            var upperLettQ = from ch in word
                             where ch <= 90 && ch >= 65
                             select ch;

            // LINQ using Functional progamming
            var upperLett = word.Where(ch => ch <= 90 && ch >= 65);

            return upperLett.ToList();
        }
    }
}
