using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _016_Power_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger finalnumber = 1;
            int start = (int)Math.Pow(2, 25);
            for (int i = 0; i < 40; i++)
            {
                finalnumber *= start;
            }
            int sum = 0;
            foreach (char c in finalnumber.ToString().ToCharArray())
            {
                sum += c - 48;
            }
            Console.WriteLine(sum.ToString("N0"));
            Console.ReadKey();
        }
    }
}
