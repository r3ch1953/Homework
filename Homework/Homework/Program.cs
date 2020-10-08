using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Homework.Classes.Comp;
using Homework.Classes.Disks;
using Homework.Classes.Output;
using Homework.Interfaces.Output;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            var comp = new Comp(new List<Disk>{ new HDD("some info on hdd", 100), new CD("some info on CD", 100) }, new List<IPrintInformation> { new Monitor()});

            bool exit = false;
            while(!exit)
            {
                int choice = 0;
                Console.Clear();
                Console.WriteLine("<<<COMP>>>\n");
                Console.WriteLine("1. ShowDisks");
                Console.WriteLine("2. ShowPrintDevices");
                Console.WriteLine("3. PrintDisksContain");
                Console.WriteLine("0. Exit\n");
                Console.Write("Enter choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                switch (choice)
                {
                    case 1:
                        comp.ShowDisk();
                        break;

                    case 2:
                        comp.ShowPrintDevice();
                        break;

                    case 3:
                        comp.Disks.ForEach(x => comp.PrintInfo("Monitor A", x.Read()));
                        break;

                    case 0:
                        exit = true;
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
