using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Help : MenuItem
    {
        private string text;
        private ItemFunc func;

        public override string Text { get => text; set => text = value; }
        public override ItemFunc Func { get => func; set => func = value; }

        public Help()
        {
            Text = "Help";
            func = () => { Console.WriteLine("Help output..."); };
        }

        public override void Execute()
        {
            func();
        }
    }
}
