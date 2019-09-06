using System;
using System.Collections.Generic;

namespace _024_Lexicographic_Permutations
{
    class Program
    {
        static void Main()
        {
            char[] baseChars = "0123456789".ToCharArray();
            List<string> permutations = new List<string> { };

            foreach (var d1 in baseChars)
            foreach (var d2 in baseChars)
            {
                foreach (var d3 in baseChars)
                foreach (var d4 in baseChars)
                foreach (var d5 in baseChars)
                foreach (var d6 in baseChars)
                foreach (var d7 in baseChars)
                foreach (var d8 in baseChars)
                foreach (var d9 in baseChars)
                foreach (var d10 in baseChars)
                {
                    char[] digits = new char[10] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10 };
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (i == j) continue;
                            if (digits[i] == digits[j]) goto skip1;
                        }
                    }

                    string tempString = "" + d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10;
                    permutations.Add(tempString);

                    skip1:;
                }
                Console.WriteLine(permutations.Count.ToString("N0"));
                    if (permutations.Count > 1000000) { Console.WriteLine(permutations[999999]); goto end; }
            }
            end: Console.ReadKey();
        }
    }
}
