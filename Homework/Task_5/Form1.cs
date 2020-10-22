using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PanelTimer.Interval = 1;
            Timer.Interval = 1000;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Panel.Location = new Point(20, 20);
            Timer.Stop();
            PanelTimer.Stop();
            MessageBox.Show($"Time {i} sec", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            i = 0;
            Timer.Start();
            PanelTimer.Start();
        }

        int i = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            Label.Text = $"{++i} sec";
        }

        private void GoRight()
        {
            Panel.Location = new Point(Panel.Location.X + 1, Panel.Location.Y);
        }

        private void GoDown()
        {
            Panel.Location = new Point(Panel.Location.X, Panel.Location.Y + 1);
        }

        private void GoUp()
        {
            Panel.Location = new Point(Panel.Location.X, Panel.Location.Y - 1);
        }

        private void GoLeft()
        {
            Panel.Location = new Point(Panel.Location.X - 1, Panel.Location.Y);
        }

        bool[] done = { false, false, false, false };
        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            int border = 20;

            if (Panel.Location.X + Panel.Width != Width - border && !done[0])
            {
                GoRight();
                done[0] = (Panel.Location.X + Panel.Width) == (Width - border) ? true : false;
            }

            if (Panel.Location.Y + Panel.Height != Height - border && done[0] && !done[1])
            {
                GoDown();
                done[1] = (Panel.Location.Y + Panel.Height) == (Height - border * 2) ? true : false;
            }

            if (Panel.Location.X != border && done[0] && done[1] && !done[2])
            {
                GoLeft();
                done[2] = (Panel.Location.X) == (border) ? true : false;
            }

            if (Panel.Location.Y != border && done[0] && done[1] && done[2] && !done[3])
            {
                GoUp();
                done[3] = (Panel.Location.Y) == (border) ? true : false;
            }

            if (done[3])
            {
                Array.Clear(done, 0, done.Length);
            }
        }
    }
}

