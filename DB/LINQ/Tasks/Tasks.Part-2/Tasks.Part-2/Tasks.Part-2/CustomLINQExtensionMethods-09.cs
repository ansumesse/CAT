using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    internal static class CustomLINQExtensionMethods_09
    {
        // Create a custom LINQ extension method to filter a collection based on a custom predicate.
        public static IEnumerable<Tsource> Filter<Tsource>(this IEnumerable<Tsource> source, Func<Tsource, bool> predicate) => source.Where(predicate);
    }
}
