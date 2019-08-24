using System;
using System.Collections.Generic;

namespace _005_Smallest_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determines the smallest number which is evenly divisible by all numbers between 1 and x\n");
            while (RepeatMe()) ;
        }

        static bool RepeatMe()
        {
            Console.WriteLine("" +
                "Input a number between 5 and 100. This is the maximum number that the smallest number must be divisible by.\n" +
                "Input 0 to exit the program.\n" +
                "Input the integer:\n");

            if (!long.TryParse(Console.ReadLine(), out long input) || input < 5 || input > 100)
            {
                Console.Clear();
                return true;
            };

            List<long> primes = new List<long> { 2 };
            for (int i = 3; i <= input; i+=2)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            long smallestNr = 1;
            foreach (var prime in primes)
            {
                if (prime * prime > input)
                {
                    smallestNr *= prime;
                    continue;
                };
                smallestNr *= (long)Math.Pow(
                    prime,
                    Math.Floor(Math.Log(input) / Math.Log(prime))
                );
            }

            Console.Clear();
            Console.WriteLine(smallestNr.ToString() + " is the smallest number divible by all numbers between 1 up to " + input);
            return true;
        }
    }
}
