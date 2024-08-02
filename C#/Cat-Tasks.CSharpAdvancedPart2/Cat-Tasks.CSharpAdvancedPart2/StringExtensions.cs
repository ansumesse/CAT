using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Tasks.CSharpAdvancedPart2
{
    internal static class StringExtensions
    {
        public static bool IsValidISBN(this string ISBN)
        {
            if (IsValidISBN_10(ISBN) || IsValidISBN_13(ISBN))
                return true;
            return false;
        }

        private static bool IsValidISBN_13(string iSBN)
        {
            throw new NotImplementedException();
        }

        private static bool IsValidISBN_10(string iSBN)
        {
            throw new NotImplementedException();
        }
    }
}
