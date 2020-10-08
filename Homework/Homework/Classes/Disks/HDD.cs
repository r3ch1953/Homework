using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Classes.Disks
{
    class HDD : Disk
    {
        public HDD(string memory = " ", int memorySize = 1) : base(memory, memorySize) { }

        public override string GetName()
        {
            return "HDD";
        }
    }
}
