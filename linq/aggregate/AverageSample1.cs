using System;
using System.Linq;

namespace aggregate
{
    class AverageSample1
    {
        public static void AverageSample1_Example()
        {
            int[] numbers = {5, 4, 3, 1, 9, 8, 6, 7, 3, 1, 7};
            double average = numbers.Average();
            Console.WriteLine($"Numbers average is {average}");
        }
    }
}