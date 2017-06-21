using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output Integers");

            Q2Integers(13);
            
        }
        private static void Q2Integers(int n)
        {
            if (n < 0) return;
            Q2Integers(n - 1); 
            Console.Write(n + " ");
        }
    }
}
