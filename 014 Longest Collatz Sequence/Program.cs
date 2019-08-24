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
            Dictionary<int, int> oddNrData = new Dictionary<int, int> { };
            for (int i = 3; i < 1e4; i+=2)
            {
                FindSteps(i, oddNrData);
            }
        }

        static int FindSteps(int testNr, Dictionary<int, int> oddNrData)
        {
            int originalNr = testNr;
            testNr *= 3;
            testNr++;
            int steps = 1;
            while (true)
            {
                if (testNr % 2 != 0)
                {
                    if (testNr == 1)
                    {
                        break;
                    }
                    bool isKnown = true;
                    for (int i = 0; i < oddNrData.Count; i++)
                    {
                        int x = oddNrData[i] * 2 + 1;

                        if (x != testNr) continue;
                        isKnown = false;
                    }
                    if (isKnown)
                    testNr *= 3;
                    testNr++;
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
