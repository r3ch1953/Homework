using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MouseClick += MainForm_Load;
        }

        List<Color> colors = new List<Color> { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Magenta };
        int iterator = -1;
        private void MainForm_Load(object sender, EventArgs e)
        { 
            if (iterator == colors.Count - 1)
                iterator = 0;
            else
                iterator++;

            BackColor = colors[iterator];
        }
    }
}
