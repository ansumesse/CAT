using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Part_1
{
    internal static class UnderstandingPure_ImpureFunctions_01
    {
        
        private static bool isPure = true; // global variable 

        // Write a pure function that filters a list of integers using LINQ.
        public static List<int> PureFunc(this List<int> Numbers)
        {
            List<int> EvenNum = Numbers.Where(x => (x % 2 == 0)).ToList();
            return EvenNum;
        }

        // Implement an impure function that modifies a global variable.
        public static void ImpureFunc()
        {
            isPure = false; // imutate global variable
        }
    }
}
