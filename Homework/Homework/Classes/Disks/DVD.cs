using Homework.Interfaces.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Classes.Disks
{
    class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;

        public bool HasDisk { get => hasDisk; }

        public DVD(string memory = " ", int memorySize = 1) : base(memory, memorySize) { }

        public void Insert()
        {
            hasDisk = true;
        }

        public void Reject()
        {
            hasDisk = false;
        }

        public override string GetName()
        {
            return "DVD";
        }
    }
}