using System;

namespace _004_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determines the largest possible palindrome for the product of two x-digit numbers where x is the number of digits input by you!\n\n");
            while (RepeatMe());
        }

        static bool RepeatMe()
        {
            Console.WriteLine("" +
                "Do NOT input anything but a positive integer greater than 1 but smaller than 9!\n" +
                "Input 0 to exit the program.\n" +
                "Input the integer:\n");

            if (!long.TryParse(Console.ReadLine(), out long input) || input < 2 || input > 8)
            {
                Console.Clear();
                return true;
            };
            long biggestPalindrome = 0;
            long upperNr = Convert.ToInt64(Math.Pow(10, input) - 1);
            long lowerNr = Convert.ToInt64(Math.Pow(10, input) - 1 - Math.Pow(10, input - 1));
            long iNr = 0, jNr = 0;

            for (long i = upperNr; i > lowerNr; i -= 2)
            {
                for (long j = i; j > lowerNr; j -= 2)
                {
                    long potentialPalindrome = i * j;
                    if (potentialPalindrome < biggestPalindrome) break;
                    char[] potentialPalindromeChars = potentialPalindrome.ToString().ToCharArray();
                    bool isPalindrome = true;
                    for (int k = 0; k < input; k++)
                    {
                        if (potentialPalindromeChars[k] != potentialPalindromeChars[potentialPalindromeChars.Length - k - 1])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        biggestPalindrome = potentialPalindrome;
                        iNr = i;
                        jNr = j;
                        break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine(iNr.ToString() + " and " + jNr.ToString() + " multiply to the following palindrome");
            Console.WriteLine("The biggest palindrome number from the product of two " + input.ToString() + "-digit numbers is : " + biggestPalindrome.ToString() + "\n");
            return true;
        }
    }
}
