using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
{
    delegate int Calculate(int[] arr);
    delegate void Change(int[] arr);

    class Program
    {
        static public List<Calculate> calculates = new List<Calculate>
        {
            (x) => x.Count(y => y < 0),

            (x) => x.Sum(),

            (x) => x.Count(y => IsSimple(y))

        };
        static public List<Change> changes = new List<Change>
        {
            (x) => Array.ForEach(x, y => { if(y < 0) { x[Array.IndexOf(x, y)] = 0; } }),
            (x) => Array.Sort(x),
            (x) =>
            {
                List<int> list = new List<int>();
                List<int> index = new List<int>();
                Array.ForEach(x, y =>
                {
                    if(y % 2 == 0)
                    {
                        list.Add(y);
                        index.Add(Array.IndexOf(x, y));
                    }

                });

                 Array.ForEach(x, y =>
                {
                    if(!index.Contains(Array.IndexOf(x, y)))
                    {
                        list.Add(y);
                    }
                });

                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = list[i];
			    }
            }
      
        };
        static public int[] arr = RandArr(15);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MainMenu();
        }

        static public void MainMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                int choice;
                Console.WriteLine("<<<MENU>>>\n");
                Console.WriteLine("1. обчислення значення");
                Console.WriteLine("2. зміна масиву");
                Console.WriteLine("3. показати масив");
                Console.WriteLine("0. вихід");
                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            CalculationMenu();
                            break;

                        case 2:
                            ChangeMenu();
                            break;

                        case 3:
                            foreach (var item in arr)
                            {
                                Console.Write($"{item,5}");
                            }
                            Console.ReadKey();
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static public void CalculationMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                int choice;
                Console.WriteLine("<<<MENU>>>\n");
                Console.WriteLine("1. Обчислити кількість негативних елементів");
                Console.WriteLine("2. Визначити суму всіх елементів");
                Console.WriteLine("3. Обрахувати кількість простих чисел");
                Console.WriteLine("0. повернутись назад");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            Console.WriteLine("\nNegetive count: " + calculates[0].Invoke(arr));
                            break;

                        case 2:
                            Console.WriteLine("\n Sum " + calculates[1].Invoke(arr));
                            break;

                        case 3:
                            Console.WriteLine("\nSimple count: " + calculates[2].Invoke(arr));
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static public void ChangeMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                int choice;
                Console.WriteLine("<<<MENU>>>\n");
                Console.WriteLine("1. Змінити всі негативні елементи на 0");
                Console.WriteLine("2. Відсортувати масив");
                Console.WriteLine("3. Перемістити всі парні елементи на початку, відповідно не парні будуть в кінці.");
                Console.WriteLine("0. повернутись назад");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;

                        case 1:
                            changes[0].Invoke(arr);
                            break;

                        case 2:
                            changes[1].Invoke(arr);
                            break;

                        case 3:
                            changes[2].Invoke(arr);
                            break;

                        default:
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static public bool IsSimple(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static public int[] RandArr(uint size)
        {
            var arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(-10, 10);
                Thread.Sleep(100);
            }
            return arr;
        }
    }
}
