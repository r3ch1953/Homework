namespace Task.Forms
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbCart = new System.Windows.Forms.CheckedListBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbCart
            // 
            this.clbCart.FormattingEnabled = true;
            this.clbCart.Location = new System.Drawing.Point(13, 4);
            this.clbCart.Name = "clbCart";
            this.clbCart.Size = new System.Drawing.Size(194, 349);
            this.clbCart.TabIndex = 0;
            this.clbCart.SelectedIndexChanged += new System.EventHandler(this.clbCart_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(214, 13);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(118, 299);
            this.lbInfo.TabIndex = 1;
            // 
            // lbPrice
            // 
            this.lbPrice.Location = new System.Drawing.Point(217, 327);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(107, 28);
            this.lbPrice.TabIndex = 2;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 364);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.clbCart);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCart;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbPrice;
    }
}