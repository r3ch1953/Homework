using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int day = 0;
            int month = 0;
            int year = 0;

            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    day = int.Parse(textBox1.Text);
                }
                catch { }
            }

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                try
                {
                    month = int.Parse(textBox2.Text);
                }
                catch { }
            }

            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                try
                {
                    year = int.Parse(textBox3.Text);
                }
                catch { }
            }

            try
            {
                monthCalendar1.TodayDate = new DateTime(year, month, day);
            }
            catch {}
        }
    }
}
