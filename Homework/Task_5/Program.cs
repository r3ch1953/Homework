using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        struct Index
        {
           public int i;
           public int j;

            public Index(int i, int j)
            {
                this.i = i;
                this.j = j;
            }
        }

        static void Main()
        {
            int size = 5;
            int[,] array = new int[size, size];

            Fill(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(new String('-', 30));

            Console.WriteLine("Sum between min and max value: " + FindSumBetweenMaxAndMinValue(array));
         
        }

        static void Fill(int[,] arr)
        {
            Random rand = new Random();

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }
        }

        static int FindSumBetweenMaxAndMinValue(int[,] arr)
        {
            int[,] ArrCopy = (int[,])arr.Clone();

            Index index1 = FindIndex(arr, Min(arr));
            Index index2 = FindIndex(arr, Max(arr));

            if (index1.Equals(new Index(-1, -1)) || index2.Equals(new Index(-1, -1)))
            {
                return 0;
            }

            if(index1.i > index2.i)
            {
                index2.i += index1.i;
                index1.i = index2.i - index1.i;
                index2.i = index2.i - index1.i;
            }    

            int sum = 0;
            for(int i = index1.i; i <= index2.i; i++)
            {
                for(int j = index1.j; j <= index2.j; j++)
                {
                    sum += ArrCopy[i, j];
                }
            }
            return sum;
        }

       static Index FindIndex(int [,] arr, int value)
       {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == value)
                        return new Index(i,j);
                }
            }
            return new Index(-1, -1);
       }

        static int Min(int[,] arr)
        {
            int min = arr[0, 0];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            return min;
        }

        static int Max(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }
    }
}
