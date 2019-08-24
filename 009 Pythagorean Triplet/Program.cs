using System;

namespace _009_Pythagorean_Triplet
{
    class Program
    {
        static void Main()
        {
            int y = 1000;
            for (int i = 10; i < y; i++)
            {
                RepeatMe(i);
                if (i % 100 == 0) Console.ReadKey();
            }
        }

        static bool RepeatMe(int ABCSum)
        {
            for (int i = ABCSum - 2; i > 0; i--)
            {
                for (int j = 1; j < i - 1; j++)
                {
                    int k = ABCSum - i - j;
                    if (i * i + j * j == k * k)
                    {
                        Console.WriteLine(i + " " + j + " " + k + " " + (i*j*k).ToString("N0"));
                    }
                }
            }
            return true;
        }
    }
}
