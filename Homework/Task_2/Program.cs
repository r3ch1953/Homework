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
            Rectangle rect = new Rectangle(11, 15, '#');
            rect.Draw();

            Console.WriteLine('\n' + new String('-', 30) + '\n');

            rect.Draw(ConsoleColor.Green);

            Console.WriteLine('\n' + new String('-', 30) + '\n');

            Console.WriteLine($"Square: {rect.Square()}");
        }
    }
}
