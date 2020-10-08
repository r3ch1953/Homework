using Homework.Interfaces.Disks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Classes.Disks
{
    abstract class Disk : IDisk
    {
        private string memory;
        private int memorySize;

        public string Memory
        { 
            get => memory; 

            set 
            {
                if (!(value.Length > memorySize))
                    memory = value;
            }
        }

        public int MemorySize { get => memorySize; set => memorySize = value; }

        public Disk(string memory = " ", int memorySize = 1)
        {
            MemorySize = memorySize;
            Memory = memory;
        }

        public string Read()
        {
            return memory;
        }

        public void Write(string s)
        {
            Memory = (s + memory);
        }

        abstract public string GetName();
    }
}
