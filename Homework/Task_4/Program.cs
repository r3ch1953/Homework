using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    struct Gistogram
    {
        public List<GistogramElement> elements;
        public int colums;

        public Gistogram(List<GistogramElement> elements = null, int colums = 100)
        {
            this.elements = elements ?? new List<GistogramElement>();
            this.colums = colums;
        }

        public override string ToString()
        {
            StringBuilder[] gistogram = new StringBuilder[colums];
            for (int i = 0; i < colums; i++)
                gistogram[i] = new StringBuilder();

            elements.Sort((x,y) => { return x.value.CompareTo(y.value); });

            foreach(var item in elements)
            {
                gistogram[0].Append(($"{item.symbol} "));
            }

            for (int i = 1; i < gistogram.Length; i++)
            {
                foreach(var item in elements)
                {
                    gistogram[i].Append($"{ (item.value >= i ? "# " : "  ") }");
                }
            }

            StringBuilder outputGistogram = new StringBuilder();

            foreach (var item in gistogram)
            {
                outputGistogram.Append(item + "\n");
            }

            return outputGistogram.ToString();
        }
    }

    struct GistogramElement
    {
        public char symbol;
        public int value;
    }

    class Program
    {
        public static List<char> alphabet = new List<char>();

        static void Main(string[] args)
        {
            for (char i = 'A'; i < 'Z'; i++)
            {
                alphabet.Add(i);
            }
            for (char i = 'a'; i < 'z'; i++)
            {
                alphabet.Add(i);
            }

            string forGistogram = "qwertyuiopasdfghjklzxcvbnmiurekmnbfsdkjeqwuioadsmb";
            Gistogram gistogram = CreateGistogram(forGistogram);
            Console.WriteLine("Gistogram ({0}):\n", forGistogram);
            Console.WriteLine(gistogram);
        }

        static Gistogram CreateGistogram(string str)
        {
            Gistogram gistogram = new Gistogram(null, str.Length);
            foreach(var item1 in alphabet)
            {
                bool inElements = false;
                foreach(var item2 in str)
                {
                    if (item2 == item1)
                    {
                        inElements = true;
                    }
                }

                if(inElements)
                {
                    if (str.Count(x => x == item1) != 0)
                    {
                        gistogram.elements.Add(new GistogramElement { symbol = item1, value = str.Count(x => x == item1) });
                    }
                }
            }
            return gistogram;
        }
    }
}
