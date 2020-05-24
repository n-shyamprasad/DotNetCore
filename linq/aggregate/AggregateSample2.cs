using System;
using System.Linq;

namespace aggregate
{
    class AggregateSample2
    {
       // aggregate sample to get products of all numbers
        public static void AggregateSample2_Example()
        {
           double startBalance = 100.0;
           int[] attemptWithdrawls = {20, 10, 40, 50, 10, 70, 30};

           double _result = attemptWithdrawls.Aggregate(startBalance, 
           (balance, nextWithdrawl) => ((nextWithdrawl <= balance) ? (balance - nextWithdrawl) : balance));
           /*(x, y) => 
           ((y <= x) ? (x - y) : x));*/

           Console.WriteLine($"Ending balance: {_result}");
        }
    }
}