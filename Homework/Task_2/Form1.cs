using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label_MouseHover(object sender, EventArgs e)
        {
            var rand = new Random();
            label.Location = new Point(rand.Next(0, ClientSize.Width - label.Width), rand.Next(0, ClientSize.Height - label.Height));
        }
    }
}
