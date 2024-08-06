using FunctionalProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class DataPartitioning_05
    {
        // Partition a large dataset into chunks for parallel processing using LINQ.
        public static IEnumerable<Employee[]> Partition(IEnumerable<Employee> employees)
        {
            var chunks = employees.Chunk(10);
            return chunks;
        }
    }
}
