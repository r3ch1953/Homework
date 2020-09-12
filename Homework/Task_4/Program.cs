using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CountWords("one word two word"));
        }

        static int CountWords(string str)
        {
            return str.Split().Length;
        }
    }
}
