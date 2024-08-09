using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tasks.Part_2
{
    public static class ElementOperations_01
    {
        // Implement a LINQ query to retrieve the first and last element from a collection.
        public static Tsource GetFirstElement<Tsource>(this IEnumerable<Tsource> source)
        {
            return (from item in source
                    select item).First();
        }
        public static Tsource GetLastElement<Tsource>(this IEnumerable<Tsource> source)
        {
            return (from item in source
                    select item).Last();
        }
    }
}
