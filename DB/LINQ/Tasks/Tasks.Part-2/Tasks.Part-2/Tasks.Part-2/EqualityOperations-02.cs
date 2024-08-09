using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class EqualityOperations_02
    {
        // Write a LINQ query to check if two sequences contain the same elements.
        public static bool CheckIfEqual<Tsource>(this IEnumerable<Tsource> source, IEnumerable<Tsource> compareWith)
        {
            if (compareWith is null)
                return false;
            return source.SequenceEqual(compareWith);
        }
    }
}
