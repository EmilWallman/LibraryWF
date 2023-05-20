namespace LibraryWF
{
    partial class Login
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.lUsername = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.lSSN = new System.Windows.Forms.Label();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubbmit = new System.Windows.Forms.Button();
            this.lError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(400, 164);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(400, 190);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Visible = false;
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(400, 216);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(100, 20);
            this.tbSSN.TabIndex = 3;
            this.tbSSN.Visible = false;
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(337, 164);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(55, 13);
            this.lUsername.TabIndex = 4;
            this.lUsername.Text = "Username";
            this.lUsername.Visible = false;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(337, 193);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(53, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Password";
            this.lPassword.Visible = false;
            // 
            // lSSN
            // 
            this.lSSN.AutoSize = true;
            this.lSSN.Location = new System.Drawing.Point(337, 219);
            this.lSSN.Name = "lSSN";
            this.lSSN.Size = new System.Drawing.Size(29, 13);
            this.lSSN.TabIndex = 6;
            this.lSSN.Text = "SSN";
            this.lSSN.Visible = false;
            // 
            // btnLoggin
            // 
            this.btnLoggin.Location = new System.Drawing.Point(589, 110);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(75, 23);
            this.btnLoggin.TabIndex = 7;
            this.btnLoggin.Text = "Loggin";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.loggin_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(699, 110);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(130, 23);
            this.btnCreateAcc.TabIndex = 8;
            this.btnCreateAcc.Text = "Create account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.createAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OR";
            // 
            // btnSubbmit
            // 
            this.btnSubbmit.Location = new System.Drawing.Point(543, 212);
            this.btnSubbmit.Name = "btnSubbmit";
            this.btnSubbmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubbmit.TabIndex = 10;
            this.btnSubbmit.Text = "Subbmit";
            this.btnSubbmit.UseVisualStyleBackColor = true;
            this.btnSubbmit.Visible = false;
            this.btnSubbmit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.BackColor = System.Drawing.Color.Red;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lError.Location = new System.Drawing.Point(350, 253);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(191, 13);
            this.lError.TabIndex = 11;
            this.lError.Text = "Incorrect Username or Password";
            this.lError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 574);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.btnSubbmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreateAcc);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.lSSN);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lUsername);
            this.Controls.Add(this.tbSSN);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lSSN;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubbmit;
        private System.Windows.Forms.Label lError;
    }
}

