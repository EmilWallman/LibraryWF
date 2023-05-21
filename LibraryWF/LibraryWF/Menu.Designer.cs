namespace LibraryWF
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditSubmit = new System.Windows.Forms.Button();
            this.comboBoxSUser = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.checkAnotherUser = new System.Windows.Forms.CheckBox();
            this.boxEditUser = new System.Windows.Forms.GroupBox();
            this.checkBoxSSN = new System.Windows.Forms.CheckBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxUsername = new System.Windows.Forms.CheckBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.btnExit = new System.Windows.Forms.Button();
            this.boxEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(92, 135);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(184, 56);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Location = new System.Drawing.Point(92, 197);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(184, 56);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "Open Library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(92, 259);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(184, 56);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(135, 156);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxInput.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input:";
            // 
            // btnEditSubmit
            // 
            this.btnEditSubmit.Location = new System.Drawing.Point(261, 156);
            this.btnEditSubmit.Name = "btnEditSubmit";
            this.btnEditSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnEditSubmit.TabIndex = 9;
            this.btnEditSubmit.Text = "Submit";
            this.btnEditSubmit.UseVisualStyleBackColor = true;
            this.btnEditSubmit.Click += new System.EventHandler(this.SubmitEditUser);
            // 
            // comboBoxSUser
            // 
            this.comboBoxSUser.FormattingEnabled = true;
            this.comboBoxSUser.Location = new System.Drawing.Point(517, 358);
            this.comboBoxSUser.Name = "comboBoxSUser";
            this.comboBoxSUser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSUser.TabIndex = 10;
            this.comboBoxSUser.Visible = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(512, 330);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(131, 25);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Select User:";
            this.Label3.Visible = false;
            // 
            // checkAnotherUser
            // 
            this.checkAnotherUser.AutoSize = true;
            this.checkAnotherUser.Location = new System.Drawing.Point(418, 338);
            this.checkAnotherUser.Name = "checkAnotherUser";
            this.checkAnotherUser.Size = new System.Drawing.Size(88, 17);
            this.checkAnotherUser.TabIndex = 12;
            this.checkAnotherUser.Text = "Another User";
            this.checkAnotherUser.UseVisualStyleBackColor = true;
            this.checkAnotherUser.Visible = false;
            this.checkAnotherUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // boxEditUser
            // 
            this.boxEditUser.Controls.Add(this.checkBoxSSN);
            this.boxEditUser.Controls.Add(this.checkBoxPassword);
            this.boxEditUser.Controls.Add(this.checkBoxUsername);
            this.boxEditUser.Controls.Add(this.btnEditSubmit);
            this.boxEditUser.Controls.Add(this.label2);
            this.boxEditUser.Controls.Add(this.textBoxInput);
            this.boxEditUser.Location = new System.Drawing.Point(405, 103);
            this.boxEditUser.Name = "boxEditUser";
            this.boxEditUser.Size = new System.Drawing.Size(425, 212);
            this.boxEditUser.TabIndex = 13;
            this.boxEditUser.TabStop = false;
            this.boxEditUser.Text = "EditUser";
            this.boxEditUser.Visible = false;
            // 
            // checkBoxSSN
            // 
            this.checkBoxSSN.AutoSize = true;
            this.checkBoxSSN.Location = new System.Drawing.Point(27, 80);
            this.checkBoxSSN.Name = "checkBoxSSN";
            this.checkBoxSSN.Size = new System.Drawing.Size(48, 17);
            this.checkBoxSSN.TabIndex = 12;
            this.checkBoxSSN.Text = "SSN";
            this.checkBoxSSN.UseVisualStyleBackColor = true;
            this.checkBoxSSN.AppearanceChanged += new System.EventHandler(this.userEditChoice3_SelectedIndexChanged);
            this.checkBoxSSN.CheckedChanged += new System.EventHandler(this.userEditChoice3_SelectedIndexChanged);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(27, 56);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPassword.TabIndex = 11;
            this.checkBoxPassword.Text = "Password";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.AppearanceChanged += new System.EventHandler(this.userEditChoice2_SelectedIndexChanged);
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.userEditChoice2_SelectedIndexChanged);
            // 
            // checkBoxUsername
            // 
            this.checkBoxUsername.AutoSize = true;
            this.checkBoxUsername.Location = new System.Drawing.Point(27, 32);
            this.checkBoxUsername.Name = "checkBoxUsername";
            this.checkBoxUsername.Size = new System.Drawing.Size(74, 17);
            this.checkBoxUsername.TabIndex = 10;
            this.checkBoxUsername.Text = "Username";
            this.checkBoxUsername.UseVisualStyleBackColor = true;
            this.checkBoxUsername.AppearanceChanged += new System.EventHandler(this.userEditChoice1_SelectedIndexChanged);
            this.checkBoxUsername.CheckedChanged += new System.EventHandler(this.userEditChoice1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 551);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 610);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.boxEditUser);
            this.Controls.Add(this.checkAnotherUser);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.comboBoxSUser);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.boxEditUser.ResumeLayout(false);
            this.boxEditUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditSubmit;
        private System.Windows.Forms.ComboBox comboBoxSUser;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.CheckBox checkAnotherUser;
        private System.Windows.Forms.GroupBox boxEditUser;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.CheckBox checkBoxSSN;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxUsername;
        private System.Windows.Forms.Button btnExit;
    }
}