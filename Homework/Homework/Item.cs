using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Item : MenuItem
    {
        private string text;
        private ItemFunc func;

        public override ItemFunc Func { get => func; set => func = value; }
        public override string Text { get => text; set => text = value; }

        public Item(ItemFunc func, string text = "empty")
        {
            Text = text;
            Func = func;
        }

        public override void Execute()
        {
            func();
        }
    }
}
