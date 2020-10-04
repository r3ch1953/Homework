using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class TeamLeader : IWorker
    {
        private string name;

        public List<StringBuilder> Reports { get; set; }
        public string Name { get => name; set => name = value; }

        public void DoWork(House house)
        {
            if(house.GetStatus())
            {
               // Reports.Add(new StringBuilder("House done"));
                return;
            }

            StringBuilder report = new StringBuilder("TeamLeader Report\n");
            foreach (var item in house.parts)
            {
                report.Append(item.ToString() + '\n');
            }
            //Reports.Add(report);
        }
    }
}