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
            Menu menu = new Menu(new List<MenuItem>() { new Exit(), new Help(), new Item(() => Console.WriteLine("My lamda func"),"My button")});
            while (true)
            {
                menu.Show();

                Console.WriteLine("Enter index: ");
                menu.Select(Int32.Parse(Console.ReadLine()));

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
