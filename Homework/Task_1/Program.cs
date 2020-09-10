using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < 5; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int[][] B = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                B[i] = new int[4];
                for (int j = 0; j < 4; j++)
                    B[i][j] = rand.Next(1, 10);
            }

            Console.Clear();

            Console.WriteLine("Array A: ");
            PrintArray(A);
            Console.WriteLine();

            Console.WriteLine("Array B: ");
            PrintArray2D(B);
            Console.WriteLine();

            Console.WriteLine(new String('-', 20));

            Console.WriteLine("Max common element: " + FindCommonMaxElement(A, B));
            Console.WriteLine("Min common element: " + FindCommonMinElement(A, B));
            Console.WriteLine("Sum: " + Sum(A, B));
            Console.WriteLine("Multiply: " + Multiply(A, B));
            Console.WriteLine("Evens array A: " + SumEvens(A));
            Console.WriteLine("Odd array B: " + SumOdd2D(B));
        }
        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
        }

        static void PrintArray2D(int[][] arr)
        {
            foreach (var item in arr)
            {
                PrintArray(item);
                Console.WriteLine();
            }
        }

        static int FindCommonMaxElement(int[] arr1, int[][] arr2)
        {
            int max = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    for (int k = 0; k < arr2[j].Length; k++)
                    {
                        if (arr2[j][k] == arr1[i] && arr1[i] >= max)
                            max = arr1[i];
                    }
                }
            }

            return max;
        }

        static int FindCommonMinElement(int[] arr1, int[][] arr2)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    for (int k = 0; k < arr2[j].Length; k++)
                    {
                        if (arr2[j][k] == arr1[i] && arr1[i] <= min)
                            min = arr1[i];
                    }
                }
            }

            return min;
        }
        
        static int Sum(int[] arr1, int[][] arr2)
        {
            int sum = arr1.Sum();
            for(int i = 0; i < arr2.Length; i++)
            {
                sum += arr2[i].Sum();
            }
            return sum;
        }
        
        static long Multiply(int[] arr1, int[][] arr2)
        {
            long res = 1;

            for (int i = 0; i < arr1.Length; i++)
                res *= arr1[i];

            for (int i = 0; i < arr2.Length; i++)
                for (int j = 0; j < arr2[i].Length; j++)
                    res *= arr2[i][j];

            return res;
        }

        static int SumEvens(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    sum += arr[i];
            }
            return sum;
        }

        static int SumOdd2D(int[][] arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 != 0)
                        sum += arr[i][j];
                }
            }

            return sum;
        }
    }
}
