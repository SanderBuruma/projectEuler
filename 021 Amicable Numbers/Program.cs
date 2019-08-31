using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Amicable_Numbers
{
    class Program
    {
        static void Main()
        {
            int divisorSum;
            int divisorSum2;
            long amicableNumbersSum = 0;
            for (int i = 1; i < 1e4; i++)
            {
                divisorSum = 0;
                divisorSum2 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) divisorSum += j;
                }
                for (int j = 1; j < divisorSum; j++)
                {
                    if (divisorSum % j == 0) divisorSum2 += j;
                }
                if (divisorSum < i & divisorSum2 == i)
                {
                    amicableNumbersSum += divisorSum;
                    amicableNumbersSum += divisorSum2;
                }
            }

            Console.WriteLine(amicableNumbersSum.ToString("N0"));
            Console.ReadKey();
        }
    }
}
