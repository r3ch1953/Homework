using Homework.Classes.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class House
    {
        private Basement basement;
        private List<Wall> walls = new List<Wall>();
        private Door door;
        private List<Window> windows = new List<Window>();
        private Roof roof;

        public List<IPart> parts { get; private set; }

        public House()
        {
            basement = new Basement();
            walls.Add(new Wall());
            walls.Add(new Wall());
            walls.Add(new Wall());
            walls.Add(new Wall());
            door = new Door();
            windows.Add(new Window());
            windows.Add(new Window());
            windows.Add(new Window());
            windows.Add(new Window());
            roof = new Roof();

            parts = new List<IPart>();
            parts.Add(basement);
            parts.AddRange(walls);
            parts.Add(door);
            parts.AddRange(windows);
            parts.Add(roof);
        }

        public bool GetStatus()
        {
            foreach (var item in parts)
            {
                if (item.Status == PartStatus.INPROCESS)
                    return false;
            }
            return true;
        }

        public void Show()
        {
            if (GetStatus())
            {
                Console.WriteLine("################\n" +
                                  "#              #\n" +
                                  "#     HOUSE    #\n" +
                                  "#              #\n" +
                                  "################\n");
            }
            else
            {
                Console.WriteLine("House not done...");
            }
        }
    }
}
