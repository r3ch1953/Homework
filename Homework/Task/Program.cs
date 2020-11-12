using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Classes;
using Task.Forms;

namespace Task
{
    static class Program
    {

        static public List<Product> Products = new List<Product>();
        static public List<Product> Cart = new List<Product>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
