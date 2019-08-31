using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _020_Factorial_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInt;
            BigInteger product;
            while (true)
            {
                Console.WriteLine("This program calculates the sum of the digits of a factorial number x");
                Console.Write("Type in a number for x: ");
                inputInt = int.Parse(Console.ReadLine()) + 1;

                product = 1;
                while (inputInt-- > 1)
                {
                    product *= inputInt;
                }

                Console.WriteLine(product.ToString("N0"));
                int digitSum = 0;
                foreach (var item in product.ToString().ToCharArray())
                {
                    digitSum += item - 48;
                }
                Console.WriteLine("sum of all digits: " + digitSum.ToString("N0"));
                Console.ReadKey();
                Console.Clear();
                
            }
        }
    }
}
