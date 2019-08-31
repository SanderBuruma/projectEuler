using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Nonabundant_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> abundantNumbers = new List<int> { };
            int divisorSum;
            long nonAbundantIntsSum = 0;
            for (int i = 0; i < 28123; i++)
            {
                divisorSum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) divisorSum += j;
                }
                if (divisorSum > i)
                {
                    abundantNumbers.Add(i);
                    if (i % 2 == 1) Console.WriteLine(i.ToString("N0"));
                }
            }
            for (int i = 0; i < 28123; i++)
            {
                for (int j = 0; j < abundantNumbers.Count; j++)
                {
                    if (abundantNumbers[j] + 12 > i)
                    {
                        nonAbundantIntsSum += i;
                        break;
                    }
                    for (int k = j; k < abundantNumbers.Count; k++)
                    {
                        if (abundantNumbers[j] + abundantNumbers[k] == i)
                        {
                            goto @continue;
                        }
                        if (abundantNumbers[j] + abundantNumbers[k] > i)
                        {
                            break;
                        }
                    }
                }
                @continue:;
            }
            Console.ReadKey();
        }
    }
}
