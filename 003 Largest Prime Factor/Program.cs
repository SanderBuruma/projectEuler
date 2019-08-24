using System;
using System.Collections.Generic;

namespace _003_Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines the largest prime factor of a given number.\n\n");
            while (RepeatMe());
        }

        static bool RepeatMe()
        {
            Console.WriteLine("" +
                "Do NOT input anything but a positive integer greater than 2!\n" +
                "Input 0 to exit the program.\n" +
                "Input the integer:\n");
            List<long> primes = new List<long> { 2};

            if (!long.TryParse(Console.ReadLine(), out long input) || input < 3) return true;
            long oldInput = input;
            long biggestPrime = 2;
            Console.Clear();

            while (input % 2 == 0) input /= 2;
            for (int i = 3; i*i <= input; i+=2)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (i%prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(i);
                    if (input % i == 0)
                    {
                        biggestPrime = i;
                        Console.WriteLine("Prime factor: " + i.ToString());
                    }
                    while (input % i == 0) input /= i;
                }
            }

            if (input > 1) biggestPrime = input;
            Console.WriteLine("The biggest prime in " + oldInput.ToString() + " is " + biggestPrime + "\nThe length of the primes array is " + primes.Count + "\n");
            return true;
        }
    }

}
