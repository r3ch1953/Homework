using Homework.Interfaces.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Classes.Output
{
    class Monitor : IPrintInformation
    {
        public string GetName()
        {
            return "Monitor";
        }

        public void Print(string s)
        {
            Console.WriteLine($"<<<{GetName()}>>> \n\n{s}");
        }
    }
}
