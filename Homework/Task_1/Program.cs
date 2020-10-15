using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static public List<string> KeyWords = File.ReadAllText(@"C:\Users\twice\Desktop\Homework\Homework\Homework\Task_1\keywords.txt").Split(" \t\n\r\b\a".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

        static void Main(string[] args)
        {
            GetComments(@"C:\Users\twice\Desktop\Homework\Homework\Homework\Task_1\Program.cs");
            ShowKeyWords(GetKeyWords(KeyWords, @"C:\Users\twice\Desktop\Homework\Homework\Homework\Task_1\Program.cs"));
        }

        // comment 1
        // comment 2

        static public string GetComments(string path)
        {
            string newPath = "comments.cs";
            StringBuilder comments = new StringBuilder();

            var file = File.ReadAllText(path);
            for (int i = 0; i < file.Length - 1; i++)
            {
                if (file[i].Equals('/') && file[i + 1].Equals('/'))
                {
                    for (int j = i; file[j] != '\n'; j++)
                    {
                        comments.Append(file[j]);
                    }
                    comments.Append('\n');
                }
            }

            File.WriteAllText(newPath, comments.ToString());
            return newPath;
        }
        static public Dictionary<string, int> GetKeyWords(List<string> words, string path)
        {
            var dict = new Dictionary<string, int>();
            var file = File.ReadAllText(path).Split();

            foreach (var i in file)
            {
                if (words.Contains(i))
                {
                    if (dict.ContainsKey(i))
                        dict[i]++;
                    else
                        dict.Add(i, 1);
                }
            }
            return dict;
        }
        static public void ShowKeyWords(Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{item.Key} ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Green;

                for (int i = 0; i < item.Value; i++)
                {
                    Console.Write('#');
                }

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write($" {item.Value}");

                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}

// comment 3
