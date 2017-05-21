using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            str = RecString(str);
            Console.WriteLine(str);
        }

        public static string RecString(string str)
        {
            if (str.Length > 0)
                return str[str.Length - 1] + RecString(str.Substring(0, str.Length - 1));
            else
                return str;
        }
    }
}
