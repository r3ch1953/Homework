using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("pic.png");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbNumber.Text))
            {
                MessageBox.Show("Error! Wrong input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbContact.Text = $"Email: {tbEmail.Text}\n" +
                             $"Number: {tbNumber.Text}\n";

            tbEmail.Text = "";
            tbNumber.Text = "";
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            var dialog = new FontDialog();
            dialog.Font = Font;
            dialog.ShowDialog();
            Font = dialog.Font;
        }

        private void btnChangeFormBg_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = BackColor;
            dialog.ShowDialog();
            BackColor = dialog.Color;
        }

        private void btnChangeTabsBg_Click(object sender, EventArgs e)
        {
            var dialog = new ColorDialog();
            dialog.Color = tabSettings.BackColor;
            dialog.ShowDialog();
            foreach (var item in tabControl.TabPages)
            {
                (item as TabPage).BackColor = dialog.Color;
            }
        }
    }
}
