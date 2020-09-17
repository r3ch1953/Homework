using System;
using System.Text;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command(encode/decode) and string to encode/decode: ");
   
            while (true)
            {
                string command = ReadWord();
                string str = Console.ReadLine();

                if (command == "encode")
                    Console.WriteLine("Your string: " + Encode(str));
                else if (command == "decode")
                    Console.WriteLine("Your string: " + Decode(str));
                else
                    Console.WriteLine("Syntax error!");
            }
        }

        static string Encode(string str)
        {
            StringBuilder newStirng = new StringBuilder(1);

            foreach(var item in str)
            {
                newStirng.Append((char)(item + 1));
            }

            return newStirng.ToString();
        }

        static string Decode(string str)
        {
            StringBuilder newStirng = new StringBuilder(1);

            foreach (var item in str)
            {
                newStirng.Append((char)(item - 1));
            }

            return newStirng.ToString();
        }

        static string ReadWord()
        {
            StringBuilder word = new StringBuilder(1);
            char symbol;
            while((symbol = (char)Console.Read()) != ' ')
            {
                word.Append(symbol);
            }

            return word.ToString();
        }
    }
}
