using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = "qwertyuiopasdfghjklzxcvbn".ToCharArray();
            int[] arrInt = { 1, 4, 5, 72, 21, 56, 4, 23, };

            Console.WriteLine("Str before sort: ");
            Array.ForEach(str, x => Console.Write($"{x}"));
            Console.WriteLine();
            Console.WriteLine("Int array before sort: ");
            Array.ForEach(arrInt, x => Console.Write($"{x,5}"));
            Console.WriteLine("\n");

            Sort(str);
            Sort(arrInt);

            Console.WriteLine("Str after sort: ");
            Array.ForEach(str, x => Console.Write($"{x}"));
            Console.WriteLine();
            Console.WriteLine("Int array after sort: ");
            Array.ForEach(arrInt, x => Console.Write($"{x,5}"));
            Console.WriteLine("\n\n");

            //SortValue(new StringBuilder("jlkfsad"));

            //ERROR//
            /* Severity Code    Description Project File Line    Suppression State
            Error CS0411  The type arguments for method 'Program.SortValue<T>(T[])' 
            cannot be inferred from the usage.Try specifying the type arguments explicitly.Homework    
            Program.cs   33  Active */

        }

        static public void Sort<T>(T[] arr) where T : IComparable
        {
            Array.Sort(arr);
        }

        static public void SortValue<T>(T[] arr) where T : struct, IComparable
        {
            Array.Sort(arr);
        }
    }
}
