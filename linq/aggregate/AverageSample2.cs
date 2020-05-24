using System;
using System.Linq;

namespace aggregate
{
    class AverageSample2
    {
        public static void AverageSample2_Example()
        {
            string[] words = {"cherry", "apple", "blueberry" };
            double avgLength = words.Average(x => x.Length);
            Console.WriteLine($"Avg. word length is {avgLength}");
        }
    }
}