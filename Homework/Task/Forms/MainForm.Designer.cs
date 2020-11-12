namespace Task.Forms
{
    partial class MainForm
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
            this.clbProducts = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbProductInfo = new System.Windows.Forms.Label();
            this.btnBuyCart = new System.Windows.Forms.Button();
            this.btnShowCart = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbProducts
            // 
            this.clbProducts.FormattingEnabled = true;
            this.clbProducts.Location = new System.Drawing.Point(13, 13);
            this.clbProducts.Name = "clbProducts";
            this.clbProducts.Size = new System.Drawing.Size(195, 304);
            this.clbProducts.TabIndex = 0;
            this.clbProducts.SelectedIndexChanged += new System.EventHandler(this.clbProducts_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(215, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbProductInfo
            // 
            this.lbProductInfo.Location = new System.Drawing.Point(215, 43);
            this.lbProductInfo.Name = "lbProductInfo";
            this.lbProductInfo.Size = new System.Drawing.Size(95, 248);
            this.lbProductInfo.TabIndex = 2;
            // 
            // btnBuyCart
            // 
            this.btnBuyCart.Location = new System.Drawing.Point(227, 294);
            this.btnBuyCart.Name = "btnBuyCart";
            this.btnBuyCart.Size = new System.Drawing.Size(75, 23);
            this.btnBuyCart.TabIndex = 3;
            this.btnBuyCart.Text = "Buy Cart";
            this.btnBuyCart.UseVisualStyleBackColor = true;
            this.btnBuyCart.Click += new System.EventHandler(this.btnBuyCart_Click);
            // 
            // btnShowCart
            // 
            this.btnShowCart.Location = new System.Drawing.Point(227, 324);
            this.btnShowCart.Name = "btnShowCart";
            this.btnShowCart.Size = new System.Drawing.Size(75, 23);
            this.btnShowCart.TabIndex = 4;
            this.btnShowCart.Text = "Show Cart";
            this.btnShowCart.UseVisualStyleBackColor = true;
            this.btnShowCart.Click += new System.EventHandler(this.btnShowCart_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(13, 324);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(195, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 361);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnShowCart);
            this.Controls.Add(this.btnBuyCart);
            this.Controls.Add(this.lbProductInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.clbProducts);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbProductInfo;
        private System.Windows.Forms.Button btnBuyCart;
        private System.Windows.Forms.Button btnShowCart;
        private System.Windows.Forms.Button btnAddProduct;
    }
}