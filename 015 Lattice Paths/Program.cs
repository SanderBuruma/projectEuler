using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Lattice_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in how big the lattice grid is for which you want to calculate the total number of unique routes: ");

            long calcLen = long.Parse(Console.ReadLine()) + 1;
            List<long>[] pascalsPyramid = new List<long>[calcLen];
            pascalsPyramid[0] = new List<long> { 1 };
            pascalsPyramid[1] = new List<long> { 1, 1 };
            for (long i = 2; i < calcLen; i++)
            {
                pascalsPyramid[i] = new List<long> {1};
                for (long j = 1; j < i; j++)
                {
                    pascalsPyramid[i].Add(pascalsPyramid[i - 1][(int)j-1] + pascalsPyramid[i - 1][(int)j]);
                }
                pascalsPyramid[i].Add(1);
            }

            long sum = 0;
            foreach (long pp in pascalsPyramid[calcLen - 1])
            {
                sum += pp * pp;
            }
            Console.WriteLine(sum);
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
