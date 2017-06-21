using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 1;        
            int Max = 100000;   

            Stopwatch timer1 = new Stopwatch(); // Stopwatch for Binary Search
            Stopwatch timer2 = new Stopwatch(); // Stopwatch for Linear Search
            int[] array = new int[100000000]; //ARRAY INCREASED to 100000000 elements

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = randNum.Next(Min, Max);
            }
                        
            Array.Sort<int>(array); 

           

            int Number = 24550; 

            timer1.Start(); // stopwatch start for Binary Search
            int index = Array.BinarySearch(array, 24550); // Binary Search
            timer1.Stop(); // stopwatch stop for Binary Search

            Console.WriteLine("Binary Search time: {0} ms", timer1.ElapsedMilliseconds); // time for Binary Search
            Console.WriteLine("Number index: {0}", index);

            int guess = 0;

            timer2.Start(); // stopwatch start for Linear Search
            for (int i = 0; i < array.Length; i++) // 
            {
                guess++;
                if (array[i] == Number)
                {
                    timer2.Stop(); // stopwatch stop
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Number {0} FOUND!!! Guesses count: {1}", array[i], guess);
                    Console.WriteLine("Linear Search time: {0} ms", timer2.ElapsedMilliseconds); // time for Linear Search
                    return;
                }
                
            }
            timer2.Stop(); // stopwatch stop
            Console.WriteLine("Search unsuccessful. Guesses count: {0}", guess);
            Console.WriteLine("Linear Search time: {0} ms", timer2.ElapsedMilliseconds); // time for Linear Search


        }
    }
}
