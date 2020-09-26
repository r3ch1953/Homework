using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Menu
    {
        public List<MenuItem> Items { get; set; }

        public Menu(List<MenuItem> items = null)
        {
            if (items != null)
                Items = items;
            else
                Items = new List<MenuItem>();
        }

        public void Show()
        {
            int counter = 0;
            Items.ForEach(x => Console.WriteLine((counter++) + " " + x.Text));
        }

        public void Select(int index)
        {
            if (index > Items.Count)
                return;

            Items[index].Execute();
        }
    }
}
