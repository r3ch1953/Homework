using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = FindLongestAndShortestWord("maximulenghtword one hjjf lds;a;lsad ddss");
            Console.WriteLine("Logest: " + words[0]);
            Console.WriteLine("Shortest: " + words[1]);
        }

        static List<string> FindLongestAndShortestWord(string str)
        {
            List<string> words = str.Split().ToList();

            int indexLongest = 0;
            int indexShortest = 0;

            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i].Length > words[indexLongest].Length)
                    indexLongest = i;

                if (words[i].Length < words[indexShortest].Length)
                    indexShortest = i;
            }

            return new List<string> { words[indexLongest], words[indexShortest] };
        }
    }
}
