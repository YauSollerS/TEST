using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 38, 32, 31, 30, 48, 48, 28, 46, 16, 5, 43, 12, 14, 15, 25, 27 };
            Array.Sort<int>(array);
            Array.Reverse(array);
            foreach (int value in array)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
