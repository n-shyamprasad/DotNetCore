using System;
using System.Linq;

namespace aggregate
{
    public class CountSample1
    {
        // Count to get the number of unique factors of 300 using method syntax.
        public static void MethodSyntaxExample()
        {
            int[] factor300 = {2, 2, 3, 5, 5};
            int uniqueFactors = factor300.Distinct().Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 300");
        }

        // Count to get the number of unique factors of 300 using query syntax.
        public static void QuerySyntaxExample()
        {
            int[] factor300 = {2, 3, 2, 5, 5};
            int uniqueFactors = 
                                (from f in factor300 select f)
                                .Distinct()
                                .Count();
            Console.WriteLine($"There are {uniqueFactors} unique factors of 300");
        }
    }
}