namespace Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lbHomeInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAboutMe = new System.Windows.Forms.TabPage();
            this.lbAboutInfo = new System.Windows.Forms.Label();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.lbContact = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnChangeTabsBg = new System.Windows.Forms.Button();
            this.lbSettingsColorTab = new System.Windows.Forms.Label();
            this.btnChangeFormBg = new System.Windows.Forms.Button();
            this.lbSettingsColorForm = new System.Windows.Forms.Label();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.lbSettingsFont = new System.Windows.Forms.Label();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabAboutMe.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lbHomeInfo);
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(768, 400);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // lbHomeInfo
            // 
            this.lbHomeInfo.Location = new System.Drawing.Point(363, 7);
            this.lbHomeInfo.Name = "lbHomeInfo";
            this.lbHomeInfo.Size = new System.Drawing.Size(402, 387);
            this.lbHomeInfo.TabIndex = 1;
            this.lbHomeInfo.Text = resources.GetString("lbHomeInfo.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 387);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabAboutMe);
            this.tabControl.Controls.Add(this.tabContact);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 426);
            this.tabControl.TabIndex = 0;
            // 
            // tabAboutMe
            // 
            this.tabAboutMe.Controls.Add(this.lbAboutInfo);
            this.tabAboutMe.Location = new System.Drawing.Point(4, 22);
            this.tabAboutMe.Name = "tabAboutMe";
            this.tabAboutMe.Padding = new System.Windows.Forms.Padding(3);
            this.tabAboutMe.Size = new System.Drawing.Size(768, 400);
            this.tabAboutMe.TabIndex = 1;
            this.tabAboutMe.Text = "About Me";
            this.tabAboutMe.UseVisualStyleBackColor = true;
            // 
            // lbAboutInfo
            // 
            this.lbAboutInfo.Location = new System.Drawing.Point(7, 7);
            this.lbAboutInfo.Name = "lbAboutInfo";
            this.lbAboutInfo.Size = new System.Drawing.Size(755, 390);
            this.lbAboutInfo.TabIndex = 1;
            this.lbAboutInfo.Text = resources.GetString("lbAboutInfo.Text");
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.lbContact);
            this.tabContact.Location = new System.Drawing.Point(4, 22);
            this.tabContact.Name = "tabContact";
            this.tabContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabContact.Size = new System.Drawing.Size(768, 400);
            this.tabContact.TabIndex = 2;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            // 
            // lbContact
            // 
            this.lbContact.Location = new System.Drawing.Point(0, 3);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(765, 394);
            this.lbContact.TabIndex = 0;
            this.lbContact.Text = "Email: example@gmail.com\r\n\r\nNumber: +123456789";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label3);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.btnSave);
            this.tabSettings.Controls.Add(this.tbNumber);
            this.tabSettings.Controls.Add(this.tbEmail);
            this.tabSettings.Controls.Add(this.btnChangeTabsBg);
            this.tabSettings.Controls.Add(this.lbSettingsColorTab);
            this.tabSettings.Controls.Add(this.btnChangeFormBg);
            this.tabSettings.Controls.Add(this.lbSettingsColorForm);
            this.tabSettings.Controls.Add(this.btnChangeFont);
            this.tabSettings.Controls.Add(this.lbSettingsFont);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(768, 400);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(349, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(349, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enail";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(664, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 49);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(455, 60);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(307, 20);
            this.tbNumber.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(455, 33);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(307, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // btnChangeTabsBg
            // 
            this.btnChangeTabsBg.Location = new System.Drawing.Point(10, 190);
            this.btnChangeTabsBg.Name = "btnChangeTabsBg";
            this.btnChangeTabsBg.Size = new System.Drawing.Size(97, 23);
            this.btnChangeTabsBg.TabIndex = 5;
            this.btnChangeTabsBg.Text = "Change";
            this.btnChangeTabsBg.UseVisualStyleBackColor = true;
            this.btnChangeTabsBg.Click += new System.EventHandler(this.btnChangeTabsBg_Click);
            // 
            // lbSettingsColorTab
            // 
            this.lbSettingsColorTab.Location = new System.Drawing.Point(7, 164);
            this.lbSettingsColorTab.Name = "lbSettingsColorTab";
            this.lbSettingsColorTab.Size = new System.Drawing.Size(155, 23);
            this.lbSettingsColorTab.TabIndex = 4;
            this.lbSettingsColorTab.Text = "Change tabs backgraund:";
            // 
            // btnChangeFormBg
            // 
            this.btnChangeFormBg.Location = new System.Drawing.Point(10, 113);
            this.btnChangeFormBg.Name = "btnChangeFormBg";
            this.btnChangeFormBg.Size = new System.Drawing.Size(97, 23);
            this.btnChangeFormBg.TabIndex = 3;
            this.btnChangeFormBg.Text = "Change";
            this.btnChangeFormBg.UseVisualStyleBackColor = true;
            this.btnChangeFormBg.Click += new System.EventHandler(this.btnChangeFormBg_Click);
            // 
            // lbSettingsColorForm
            // 
            this.lbSettingsColorForm.Location = new System.Drawing.Point(7, 87);
            this.lbSettingsColorForm.Name = "lbSettingsColorForm";
            this.lbSettingsColorForm.Size = new System.Drawing.Size(155, 23);
            this.lbSettingsColorForm.TabIndex = 2;
            this.lbSettingsColorForm.Text = "Change form backgraund:";
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(10, 33);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(97, 23);
            this.btnChangeFont.TabIndex = 1;
            this.btnChangeFont.Text = "Change";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // lbSettingsFont
            // 
            this.lbSettingsFont.Location = new System.Drawing.Point(7, 7);
            this.lbSettingsFont.Name = "lbSettingsFont";
            this.lbSettingsFont.Size = new System.Drawing.Size(100, 23);
            this.lbSettingsFont.TabIndex = 0;
            this.lbSettingsFont.Text = "Font:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Task";
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabAboutMe.ResumeLayout(false);
            this.tabContact.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lbHomeInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAboutMe;
        private System.Windows.Forms.Label lbAboutInfo;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Button btnChangeTabsBg;
        private System.Windows.Forms.Label lbSettingsColorTab;
        private System.Windows.Forms.Button btnChangeFormBg;
        private System.Windows.Forms.Label lbSettingsColorForm;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Label lbSettingsFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbEmail;
    }
}

