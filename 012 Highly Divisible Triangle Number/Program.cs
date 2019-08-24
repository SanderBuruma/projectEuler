using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Highly_Divisible_Triangle_Number
{
    class Program
    {
        static void Main()
        {
            long adder = 2;
            long sum = 1;
            int maxDivisors = 1;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //build primes list
            List<int> primes = new List<int> { 2 };
            int potentialPrime = 3;
            while (potentialPrime < 15000)
            {
                bool isPrime = true;
                foreach (var v in primes)
                {
                    if (v * v > potentialPrime) break;
                    if (potentialPrime % v == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) primes.Add(potentialPrime);
                potentialPrime += 2;
            }

            while (maxDivisors < 5000)
            {
                sum += adder;
                adder += 1;

                int divisors = 1;
                foreach (int prime in primes)
                {
                    int temp = 1;
                    while (sum % Math.Pow(prime, temp) == 0) temp++; 
                    divisors *= temp;
                }

                if (divisors > maxDivisors)
                {
                    Console.WriteLine(divisors.ToString() + " " + sum.ToString("N0") + " " + adder.ToString("N0"));
                    maxDivisors = divisors;
                }
                if (adder % 500 == 0) Console.WriteLine(adder.ToString() + " " + sw.ElapsedMilliseconds);
            }
            Console.ReadLine();
        }
    }
}
