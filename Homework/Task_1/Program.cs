using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LinearEquation linearEquation = LinearEquation.Parse("10 0");
                Console.WriteLine(linearEquation);
                Console.WriteLine("X = " + linearEquation.Slove());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
