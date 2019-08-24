using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Number_Letter_Counts
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, int> numLCounts = new Dictionary<int, int> { };
            numLCounts.Add(90, "ninety".Length);
            numLCounts.Add(80, "eighty".Length);
            numLCounts.Add(70, "seventy".Length);
            numLCounts.Add(60, "sixty".Length);
            numLCounts.Add(50, "fifty".Length);
            numLCounts.Add(40, "forty".Length);
            numLCounts.Add(30, "thirty".Length);
            numLCounts.Add(20, "twenty".Length);
            numLCounts.Add(19, "nineteen".Length);
            numLCounts.Add(18, "eighteen".Length);
            numLCounts.Add(17, "seventeen".Length);
            numLCounts.Add(16, "sixteen".Length);
            numLCounts.Add(15, "fifteen".Length);
            numLCounts.Add(14, "fourteen".Length);
            numLCounts.Add(13, "thirteen".Length);
            numLCounts.Add(12, "twelve".Length);
            numLCounts.Add(11, "eleven".Length);
            numLCounts.Add(10, "ten".Length);
            numLCounts.Add(9, "nine".Length);
            numLCounts.Add(8, "eight".Length);
            numLCounts.Add(7, "seven".Length);
            numLCounts.Add(6, "six".Length);
            numLCounts.Add(5, "five".Length);
            numLCounts.Add(4, "four".Length);
            numLCounts.Add(3, "three".Length);
            numLCounts.Add(2, "two".Length);
            numLCounts.Add(1, "one".Length);

            int LetterCount = 11;
            for (int i = 1; i < 1000; i++)
            {
                int first2Digits = i % 100;
                foreach (var v in numLCounts)
                {
                    if (v.Key <= first2Digits)
                    {
                        first2Digits -= v.Key;
                        LetterCount += v.Value;
                    }
                }
                if (i > 99)
                {
                    int lastDigits = i / 100;
                    LetterCount += 7;
                    if (i % 100 != 0) LetterCount += 3;
                    foreach (var v in numLCounts)
                    {
                        if (v.Key <= lastDigits)
                        {
                            lastDigits -= v.Key;
                            LetterCount += v.Value;
                        }
                    }
                }
            }
            Console.Write(LetterCount.ToString("N0"));
            Console.ReadKey();
        }
    }
}
