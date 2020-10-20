using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    class Program
    {
        static public Form form;
        static public Label label;
        static public Dictionary<MouseButtons, int> pressed;

        static Program()
        {
            form = new Form();
            form.Size = new Size(800, 600);
            label = new Label();
            pressed = new Dictionary<MouseButtons, int>();
            pressed.Add(MouseButtons.Left, 0);
            pressed.Add(MouseButtons.Right, 0);
            pressed.Add(MouseButtons.Middle, 0);

            form.MouseClick += Form_Click;
            form.Controls.Add(label);
        }

        private static void Form_Click(object sender, MouseEventArgs e)
        {
            form.CreateGraphics().Clear(Color.White);
            form.CreateGraphics().FillEllipse(new SolidBrush(Color.Black), new Rectangle(e.X, e.Y, 10, 10));

            label.Text = $"Button: {e.Button.ToString()}";

            pressed[e.Button]++;
            form.Text = $"Left: {pressed[MouseButtons.Left]}, Right: {pressed[MouseButtons.Right]}, Middle: {pressed[MouseButtons.Middle]}";
        }

        static void Main(string[] args)
        {
            form.ShowDialog();
        }
    }
}
