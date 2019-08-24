using System;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the sum of all numbers from 1 to x where x is an integer you input, adding only the numbers which are multiples of 3, 5 or both.");
            while (RepeatMe());
        }

        static bool RepeatMe()
        {
            Console.WriteLine("Do NOT input anything but an integer! Else the program will crash.\n" +
                "Input 0 to exit the program.\n" +
                "Input the integer:\n");
            long sum = 0;
            long x = long.Parse(Console.ReadLine());
            Console.Clear();

            //exit program if x is 0
            if (x == 0) return false;

            for (int i = 0; i <= x; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.WriteLine(sum.ToString("0") + " is the sum of all integers between 1 and " + x + " which are multiples of 3, 5 or both\n\n");
            return true;
        }
    }
}
