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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            clbCart.Items.Clear();
            clbCart.Items.AddRange(Program.Cart.ToArray());

            float price = 0;
            foreach (var item in Program.Cart)
            {
                price += item.Price;
            }

            lbPrice.Text = $"Cart Price: {price}";
        }

        private void clbCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbInfo.Text = (clbCart.SelectedItem as Product).GetFullInfo();
        }
    }
}
