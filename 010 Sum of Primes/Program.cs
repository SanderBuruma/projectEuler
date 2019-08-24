using System;
using System.Diagnostics;

namespace _010_Sum_of_Primes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Calculate the sum of all primes up to a given number.\nMaximum Prime: ");
            long maxPrime = long.Parse(Console.ReadLine());
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool[] primes = new bool[maxPrime];
            long sum = 0;
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            for (long i = 2; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            for (long i = 2; i < primes.Length; i++)
            {
                if (!primes[i]) continue;
                sum += i;
                //numbers below maxPrime do not contain factors smaller than the square root of maxPrime and thus this can be skipped
                if (i * i > maxPrime) continue;
                for (long j = i + i; j < maxPrime; j+=i)
                {
                    primes[j] = false;
                }
            }
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
            Console.Write(sum.ToString("N0"));
        }
    }
}
