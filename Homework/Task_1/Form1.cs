using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class MainForm : Form
    {
        private PictureBox img = new PictureBox();

        private int x;
        private int y;

        private int size;

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            img.Load(@"C:\Users\twice\Desktop\Homework\Homework\Homework\Task_1\Resource\anger.png");
            x = ClientSize.Width / 2;
            y = ClientSize.Height / 2;
            size = 128;
            DoubleBuffered = true;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        { 
           e.Graphics.DrawImage(img.Image, new Rectangle(x - img.Image.Width / 2, y - img.Image.Height / 2, size, size));
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                    x = 0;
                    y = 0;
                    break;

                case Keys.D1:
                    x = ClientSize.Width - img.Image.Width;
                    y = ClientSize.Height - img.Image.Height;
                    break;

                case Keys.Add:
                    if (size <= ClientSize.Width && size <= ClientSize.Height)
                        size++;
                    break;

                case Keys.Subtract:
                    if (size >= 10)
                        size--;
                    break;

                case Keys.Up:
                    if (e.Control)
                        y -= 100;
                    else
                        y -= 10;
                    break;

                case Keys.Down:
                    if (e.Control)
                        y += 100;
                    else
                        y += 10;
                    break;

                case Keys.Left:
                    if (e.Control)
                        x -= 100;
                    else
                        x -= 10;
                    break;

                case Keys.Right:
                    if (e.Control)
                        x += 100;
                    else
                        x += 10;
                    break;
            }

            if (x >= ClientSize.Width)
                x = -img.Image.Width;
            if (x <= -img.Image.Width) 
                x = ClientSize.Width;

            if (y >= ClientSize.Height)
                y = -img.Image.Height;
            if (y <= -img.Image.Height)
                y = ClientSize.Height;

            Invalidate();
        }
    }
}

