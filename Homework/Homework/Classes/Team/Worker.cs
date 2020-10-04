using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Worker : IWorker
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public void DoWork(House house)
        {
            for (int i = 0; i < house.parts.Count; i++)
            {
                if (house.parts[i].Status == PartStatus.INPROCESS)
                {
                    house.parts[i].Status = PartStatus.DONE;
                    return;
                }
            }
        }
    }
}
