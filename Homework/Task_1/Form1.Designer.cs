namespace Task_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.clbEmployees = new System.Windows.Forms.CheckedListBox();
            this.pgLoadingEmployees = new System.Windows.Forms.ProgressBar();
            this.lLoadingEmployees = new System.Windows.Forms.Label();
            this.lEmployeeInfo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbStreet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pError = new System.Windows.Forms.Panel();
            this.lErrors = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.tLoading = new System.Windows.Forms.Timer(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.pError.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbEmployees
            // 
            this.clbEmployees.FormattingEnabled = true;
            this.clbEmployees.Location = new System.Drawing.Point(13, 13);
            this.clbEmployees.Name = "clbEmployees";
            this.clbEmployees.Size = new System.Drawing.Size(182, 379);
            this.clbEmployees.TabIndex = 0;
            this.clbEmployees.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbEmployees_ItemCheck);
            this.clbEmployees.SelectedIndexChanged += new System.EventHandler(this.clbEmployees_SelectedIndexChanged);
            // 
            // pgLoadingEmployees
            // 
            this.pgLoadingEmployees.Location = new System.Drawing.Point(13, 415);
            this.pgLoadingEmployees.Name = "pgLoadingEmployees";
            this.pgLoadingEmployees.Size = new System.Drawing.Size(552, 23);
            this.pgLoadingEmployees.TabIndex = 1;
            // 
            // lLoadingEmployees
            // 
            this.lLoadingEmployees.AutoSize = true;
            this.lLoadingEmployees.Location = new System.Drawing.Point(13, 396);
            this.lLoadingEmployees.Name = "lLoadingEmployees";
            this.lLoadingEmployees.Size = new System.Drawing.Size(57, 13);
            this.lLoadingEmployees.TabIndex = 2;
            this.lLoadingEmployees.Text = " Loading...";
            // 
            // lEmployeeInfo
            // 
            this.lEmployeeInfo.AutoSize = true;
            this.lEmployeeInfo.Location = new System.Drawing.Point(201, 20);
            this.lEmployeeInfo.Name = "lEmployeeInfo";
            this.lEmployeeInfo.Size = new System.Drawing.Size(48, 52);
            this.lEmployeeInfo.TabIndex = 3;
            this.lEmployeeInfo.Text = "Name: \r\nPositon:\r\nSalary:\r\nAddress:";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(476, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(444, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 5;
            this.tbName.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(444, 39);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(121, 20);
            this.tbSalary.TabIndex = 6;
            this.tbSalary.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(444, 65);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPosition.TabIndex = 7;
            this.cbPosition.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(444, 92);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 21);
            this.cbCity.TabIndex = 8;
            this.cbCity.TextChanged += new System.EventHandler(this.city_TextChanged);
            // 
            // cbStreet
            // 
            this.cbStreet.FormattingEnabled = true;
            this.cbStreet.Location = new System.Drawing.Point(444, 119);
            this.cbStreet.Name = "cbStreet";
            this.cbStreet.Size = new System.Drawing.Size(121, 21);
            this.cbStreet.TabIndex = 9;
            this.cbStreet.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Posotion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Street";
            // 
            // pError
            // 
            this.pError.Controls.Add(this.lErrors);
            this.pError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pError.Location = new System.Drawing.Point(204, 210);
            this.pError.Name = "pError";
            this.pError.Size = new System.Drawing.Size(361, 182);
            this.pError.TabIndex = 15;
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lErrors.Location = new System.Drawing.Point(3, 9);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(0, 16);
            this.lErrors.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(206, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Error Log";
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(201, 84);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 17;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tLoading
            // 
            this.tLoading.Tick += new System.EventHandler(this.tLoading_Tick);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(201, 125);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStreet);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lEmployeeInfo);
            this.Controls.Add(this.lLoadingEmployees);
            this.Controls.Add(this.pgLoadingEmployees);
            this.Controls.Add(this.clbEmployees);
            this.Name = "Form1";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pError.ResumeLayout(false);
            this.pError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbEmployees;
        private System.Windows.Forms.ProgressBar pgLoadingEmployees;
        private System.Windows.Forms.Label lLoadingEmployees;
        private System.Windows.Forms.Label lEmployeeInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pError;
        private System.Windows.Forms.Label lErrors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Timer tLoading;
        private System.Windows.Forms.Button btnEdit;
    }
}

