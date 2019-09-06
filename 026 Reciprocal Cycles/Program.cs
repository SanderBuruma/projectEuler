using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _026_Reciprocal_Cycles
{
    class Program
    {
        static void Main()
        {
            BigInteger bigInt = 100000000000;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;
            bigInt = bigInt * bigInt * bigInt;


            for (int i = 950; i < 1e5; i++)
            {
                BigInteger tempInt = bigInt / i;
                var tempChars = tempInt.ToString();
                for (int j = 1; j < 1000; j++)
                {
                    var substr = tempChars.Substring(tempChars.Length - j);
                    var tempStr2 = tempChars.Replace(substr, "");
                    if (tempStr2.Length < i)
                    {
                        if (j > 10)
                        {
                            Console.Write(i.ToString("N0") + " ");
                            Console.WriteLine(j.ToString("N0"));
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
