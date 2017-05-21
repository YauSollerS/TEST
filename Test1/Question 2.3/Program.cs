using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = -8;
            float a = 3.5F;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            float y=IterMult(a, b);
            timer.Stop();
            Console.WriteLine(y);
            Console.WriteLine("Iteration time {0} ms", timer.ElapsedMilliseconds);
        }
        private static float IterMult(float x, int n)
        {
            if (n >= 0)
            {
                float res1 = 1;
                for (int i = 0; i < n; i++)
                {

                    res1 = res1 * x;
                }
                return res1;
            }
            else
            {
                float res2 = 1;
                for (int i = 0; i < (n * (-1)); i++)
                {
                    res2 = res2 * x;
                }
                float g = 1 / res2;
                return g;
            }
        }
    }
}
