using System;
using System.Linq;

namespace aggregate
{
    class AggregateSample1
    {
       // aggregate sample to get products of all numbers
        public static void AggregateSample1_Example()
        {
            double[] _ardouble = {2.1, 1.6, 4.1, 1.9, 2.5, 3.2};
            Console.WriteLine($"Product of all numbers: {_ardouble.Aggregate((x, y) => x * y)}");
        }
    }
}