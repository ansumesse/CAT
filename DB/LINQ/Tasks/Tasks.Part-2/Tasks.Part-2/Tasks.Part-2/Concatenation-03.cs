using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_2
{
    public static class Concatenation_03
    {
        // Concatenate two sequences using the LINQ Concat method.
        public static IEnumerable<Tsource> Concatenate<Tsource>(this IEnumerable<Tsource> source, IEnumerable<Tsource> second)
        {
            if (second is null)
                return source;
            return source.Concat(second);
        }
    }
}
