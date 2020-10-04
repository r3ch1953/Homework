using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Team team = new Team(house, new List<IWorker>
                                            { new Worker { Name = "Vasay" },
                                              new Worker { Name = "Ivan" },
                                              new TeamLeader { Name = "Temaleder" }});

            house.Show();
            team.BuildHouse();
            house.Show();

            Console.WriteLine(team.GetTeamLeaderReports());
        }
    }
}
