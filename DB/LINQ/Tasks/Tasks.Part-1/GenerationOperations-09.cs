using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal class GenerationOperations_09
    {
        // Generate a sequence of numbers using LINQ and range operators.
        public static IEnumerable<int> GetNums(int from, int to)
        {
            var numbers = Enumerable.Range(from, to - from + 1).Select(x => x);
            return numbers;
        }

        // Create a LINQ query to generate a sequence of dates within a specified range.
        public static IEnumerable<DateTime> GetDatesInRange(DateTime from, DateTime to)
        {
            var Days = (to - from).Days;

            var DatesInRange = Enumerable.Range(0, Days + 1).Select(x => from.AddDays(x));
            return DatesInRange;
        }
    }
}
