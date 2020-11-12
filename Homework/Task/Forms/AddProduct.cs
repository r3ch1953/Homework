using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Classes;

namespace Task.Forms
{
    public partial class AddProduct : Form
    {
        public Product Result { get; private set; }

        public AddProduct()
        {
            InitializeComponent();
            Result = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Errors())
            {
                MessageBox.Show("Wrong input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Result = new Product(tbName.Text, tbInfo.Text, tbSpecification.Text, (float)nudPrice.Value);
            Close();
        }

        private bool Errors()
        {
            if (string.IsNullOrEmpty(tbName.Text))
                return true;
            if (string.IsNullOrEmpty(tbInfo.Text))
                return true;
            if (string.IsNullOrEmpty(tbSpecification.Text))
                return true;

            return false;
        }
    }
}
