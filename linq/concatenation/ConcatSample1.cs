using System;
using System.Linq;

namespace concatenation
{
    public static class Concatsample1
    {
        public static void MethodSyntaxExample()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var allNumbers = numbersA.Concat(numbersB);
            Console.WriteLine("All numbers from both arrays");
            foreach (var item in allNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}