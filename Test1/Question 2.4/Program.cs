using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 14;
            float a = 3.5F;
            Stopwatch timer = new Stopwatch();
            timer.Start();            float y = RecMult(a, b);
            timer.Stop();
            Console.WriteLine(y);
            Console.WriteLine("Recursion time {0} ms", timer.ElapsedMilliseconds);
        }
        private static float RecMult(float x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n > 0)
            {
                return x*RecMult(x,n-1);
            }
            else
            {
                return RecMult(x,n+1)/x;
            }
        }
    }
}
