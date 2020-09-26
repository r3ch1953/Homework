using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Exit : MenuItem
    {
        private string text;
        private ItemFunc func;
        public override string Text { get => text; set => text = value; }
        public override ItemFunc Func { get => func; set => func = value; }

        public Exit()
        {
            Text = "Exit";
            func = () => { System.Environment.Exit(0); };
        }

        public override void Execute()
        {
            func();
        }
    }
}
