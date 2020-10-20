using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var quiz = new Quiz("quiz", new List<Question> {
                new Question("Struct is value type?", true),
                new Question("Class is value type?", false),
                new Question("Struct can implement interfaces?", true),
                new Question("System call method main?", true),
                new Question("Main takes List<string> args?", false)});

            MessageBox.Show($"Your score: {quiz.Run()}/{quiz.Questions.Count}!");
        }
    }
}
