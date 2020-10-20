using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    class Question
    {
        public string Text { get; set; }
        public bool Answer { get; set; }

        public Question(string text = "Sample question", bool answer = false)
        {
            Text = text;
            Answer = answer;
        }

        public bool Check(DialogResult answer)
        {
            switch (answer)
            {
                case DialogResult.Yes:
                    if (Answer == true)
                        return true;
                    break;
                case DialogResult.No:
                    if (Answer == false)
                        return true;
                    break;
            }
            return false;
        }
    }
}
