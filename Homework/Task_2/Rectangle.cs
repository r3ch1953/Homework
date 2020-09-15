using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public char Symbol { get; set; }

        public Rectangle()
        {
            Height = 10;
            Width = 10;
            Symbol = '#';
        }

        public Rectangle(int height = 10, int width = 10, char symbol = '#')
        {
            Height = height;
            Width = width;
            Symbol = symbol;
        }

        public int Square()
        {
            return Height * Width;
        }

        public void Draw()
        {
            for(int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++)
                {
                    Console.Write(Symbol + " ");
                }
                Console.WriteLine();
            }
        }

        public void Draw(ConsoleColor color = ConsoleColor.White)
        {
            Console.BackgroundColor = color;
            Console.ForegroundColor = color;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(Symbol + " ");
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
