using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Is palindrom: " + IsPalindrom(str));
        }

        static bool IsPalindrom(string str)
        {
            return str.ToLower() == ReverseString(str).ToLower();
        }

        static string ReverseString(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
