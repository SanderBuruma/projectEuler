using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Longest_Collatz_Sequence
{
    class Program
    {
        static void Main()
        {
            long max = 1500000;
            List<long> oddNrData = new List<long> { 0 };
            for (long i = 0; i < max/4; i++)
            {
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
                oddNrData.Add(-1);
            }
            for (long i = 3; i < oddNrData.Count; i+=2)
            {
                FindSteps(i, oddNrData);
            }
            while(true)
            {
                Console.Write("\nFind the number with the most collatz steps which is smaller than x. Type in a value for x: ");
                long findMaxNr = long.Parse(Console.ReadLine()) / 2;
                long largestNr = 0;
                long largestSteps = 0;
                for (int i = 0; i < findMaxNr; i++)
                {
                    if (i > oddNrData.Count - 2)
                    {
                        Console.WriteLine("x is too big");
                        break;
                    }
                    if (oddNrData[i] > largestSteps)
                    {
                        largestSteps = oddNrData[i];
                        largestNr = i;
                    }
                }
                Console.WriteLine((largestNr*2+1).ToString("N0") + " steps: " + largestSteps.ToString("N0"));
            }
        }

        static long FindSteps(long testNr, List<long> oddNrData)
        {
            long originalNr = testNr;
            testNr *= 3;
            testNr++;
            long steps = 1;
            while (true)
            {
                if (testNr % 2 != 0)
                {
                    if ((testNr - 1) / 2 >= oddNrData.Count || oddNrData[((int)testNr - 1) / 2] == -1)
                    {
                        testNr *= 3;
                        testNr++;
                    }
                    else
                    {
                        steps += oddNrData[((int)testNr - 1) / 2];
                        oddNrData[((int)originalNr - 1) / 2] = steps;
                        break;
                    }
                }
                else
                {
                    testNr /= 2;
                    steps++;
                }
            }

            return steps;
        }
    }
}
