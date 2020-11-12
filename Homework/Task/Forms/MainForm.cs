using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task.Classes;

namespace Task.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var add = new AddProduct();
            Visible = false;
            add.ShowDialog();
            Visible = true;

            if (add.Result != null)
            {
                Program.Products.Add(add.Result);
            }

            clbProducts.Items.Clear();
            clbProducts.Items.AddRange(Program.Products.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!(clbProducts.CheckedItems.Count >= 1))
            {
                return;
            }

            Program.Cart.Add(clbProducts.CheckedItems[0] as Product);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clbProducts.Items.Clear();
            clbProducts.Items.AddRange(Program.Products.ToArray());
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            var cart = new Cart();
            Visible = false;
            cart.ShowDialog();
            Visible = true;
        }

        private void btnBuyCart_Click(object sender, EventArgs e)
        {
            float totalSum = 0;
            foreach (var item in Program.Cart)
            {
                totalSum += item.Price;
            }

            MessageBox.Show($"Total sum: {totalSum}. Cart Cleared", "Buy", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.Cart.Clear();
        }

        private void clbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbProductInfo.Text = (clbProducts.SelectedItem as Product).GetFullInfo();
        }
    }
}
