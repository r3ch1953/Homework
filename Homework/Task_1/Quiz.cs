using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class Quiz
    {
        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz(string name = "QUIZZZZ", List<Question> questions = null)
        {
            Name = name;

            if (questions == null)
                questions = new List<Question>();

            Questions = questions;
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public int Run()
        {
            int result = 0;

            foreach (var item in Questions)
            {
                var res = MessageBox.Show(item.Text, Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (item.Check(res))
                    result++;
            }

            return result;
        }
    }
}
