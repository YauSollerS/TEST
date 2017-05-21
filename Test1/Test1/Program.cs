using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output Integers");
            Q1Integers(13);

        }
        private static void Q1Integers(int n) 
        {
            if (n < 0) return;
            Console.Write(n + " ");
            Q1Integers(n-1);
                       

        }
    }
}
