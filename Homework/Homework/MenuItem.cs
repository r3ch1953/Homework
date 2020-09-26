using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{

    delegate void ItemFunc();
    abstract class MenuItem
    {
        public abstract ItemFunc Func { get; set; }
        public abstract string Text { get; set; }
        public abstract void Execute();
    }
}
