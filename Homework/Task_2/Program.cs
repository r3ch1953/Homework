using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AllSymbolsToUpAndDelAllAfterLast("my string a a a b b b c c a dksjlfdsk", 'a'));
        }

        static string AllSymbolsToUpAndDelAllAfterLast(string str, char symbol)
        {
            StringBuilder newString = new StringBuilder(1);
            int indexLastFounded = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    indexLastFounded = i;
                    newString.Append(Char.ToUpper(str[i]));
                }
                else
                    newString.Append(str[i]);
            }

            newString.Remove(indexLastFounded + 1, newString.Length - indexLastFounded - 1);

            return newString.ToString();
        }
    }
}
