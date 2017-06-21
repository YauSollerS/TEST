using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Moomintroll", "Snorkmaiden", "Little My", "Snufkin", "Sniff", "Stinky" }; //array

            Random randNum = new Random();

            string temp;
            int j;
            int i = array.Length-1;
                        
            while (i > 0) //shuffling
            {
                j = randNum.Next(0, i);
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                i--;
            }


            foreach (string value in array)
            {
                Console.Write(value +" ");
            }
        }
    }
}
