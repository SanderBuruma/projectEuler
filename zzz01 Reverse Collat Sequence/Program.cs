using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzz01_Reverse_Collat_Sequence
{
    //determines the number of steps a number can go in a reverse collat sequence before becoming a multiple of 3 and therefor no longer being able to jump across branches
    class Program
    {
        static void Main(string[] args)
        {
            long y = 5, x;
            long steps;
            long whileCondition = 155;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 3; i++)
            {
                whileCondition *= whileCondition;
            }
            var stepHighscores = new List<long> { };
            for (int i = 0; i < 5; i++)
            {
                stepHighscores.Add(10);
            }

            while (y++ < whileCondition)
            {
                x = y;
                steps = 0;
                while (true)
                {
                    if (x < 3 || x % 3 == 0) break;
                    steps++;
                    if ((x - 1) % 3 == 0)
                    {
                        x = (x - 1) / 3 * 2;
                        steps++;
                    }
                    else x *= 2;
                    if (x > whileCondition) break;
                }
                if (steps > stepHighscores[0])
                {
                    Console.WriteLine("y: " + y.ToString("N0") + " steps: " + steps.ToString("N0") + " x: " + x.ToString("N0") + " sw: " + (((float)sw.ElapsedTicks) / Stopwatch.Frequency * 1000000).ToString("N0") + " us");
                    sw.Restart();
                    stepHighscores.Add(steps);
                    stepHighscores = stepHighscores.OrderBy(i => i).ToList();
                    stepHighscores.RemoveAt(0);
                }
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
