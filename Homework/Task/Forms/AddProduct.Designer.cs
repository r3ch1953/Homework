namespace Task.Forms
{
    partial class AddProduct
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.tbInfo = new MetroFramework.Controls.MetroTextBox();
            this.tbSpecification = new MetroFramework.Controls.MetroTextBox();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 13);
            this.tbName.Name = "tbName";
            this.tbName.PromptText = "Name";
            this.tbName.Size = new System.Drawing.Size(194, 23);
            this.tbName.TabIndex = 1;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(12, 42);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.PromptText = "Info";
            this.tbInfo.Size = new System.Drawing.Size(194, 23);
            this.tbInfo.TabIndex = 2;
            // 
            // tbSpecification
            // 
            this.tbSpecification.Location = new System.Drawing.Point(12, 71);
            this.tbSpecification.Name = "tbSpecification";
            this.tbSpecification.PromptText = "Specification";
            this.tbSpecification.Size = new System.Drawing.Size(194, 23);
            this.tbSpecification.TabIndex = 3;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(86, 100);
            this.nudPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 20);
            this.nudPrice.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price: ";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 191);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.tbSpecification);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroTextBox tbInfo;
        private MetroFramework.Controls.MetroTextBox tbSpecification;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label1;
    }
}