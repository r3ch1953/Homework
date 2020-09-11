using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Msize = 10;
            int Nsize = 5;
            int[] M = new int[Msize];
            int[] N = new int[Nsize];
            int[] NewArr = default;

            FillArray(M);
            FillArray(N);

            for (int i = 0; i < Msize; i++)
            {
                for (int j = 0; j < Nsize; j++)
                {
                    if (M[i] == N[j])
                    {
                        if (!InArray(NewArr, M[i]))
                        {
                            AddToArray(ref NewArr, M[i]);
                        }
                    }
                }
            }

            Console.WriteLine("Array M:");
            foreach (var item in M)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("Array N:");
            foreach (var item in N)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("Array NewArr:");
            foreach (var item in NewArr)
            {
                Console.Write(item + " ");
            }
        }

        static bool InArray(int[] arr, int var)
        {
            if (arr == null)
                return false;

            foreach (var item in arr)
            {
                if (item == var)
                {
                    return true;
                }
            }
            return false;
        }

        static void AddToArray(ref int[] arr, int var)
        {
            if (arr == null)
                Array.Resize(ref arr, 1);
            else
                Array.Resize(ref arr, arr.Length + 1);

            arr[arr.Length - 1] = var;
        }

        static void FillArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 10);
        }
    }
}
