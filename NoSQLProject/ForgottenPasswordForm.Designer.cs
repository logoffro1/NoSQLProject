namespace NoSQLProject
{
    partial class ForgottenPasswordForm
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.AuthenticationTxtBox = new System.Windows.Forms.TextBox();
            this.AuthenticationLbl = new System.Windows.Forms.Label();
            this.AuthenticationBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsernameTextLbl = new System.Windows.Forms.Label();
            this.NewPasswordLbl = new System.Windows.Forms.Label();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.ShowUsernameLbl = new System.Windows.Forms.Label();
            this.EmailTextLbl = new System.Windows.Forms.Label();
            this.ShowEmailLbl = new System.Windows.Forms.Label();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(248, 153);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(210, 43);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "...";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(248, 125);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(210, 22);
            this.UsernameTxtBox.TabIndex = 2;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(245, 105);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(77, 17);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "Username:";
            // 
            // AuthenticationTxtBox
            // 
            this.AuthenticationTxtBox.Location = new System.Drawing.Point(248, 125);
            this.AuthenticationTxtBox.Name = "AuthenticationTxtBox";
            this.AuthenticationTxtBox.Size = new System.Drawing.Size(210, 22);
            this.AuthenticationTxtBox.TabIndex = 5;
            // 
            // AuthenticationLbl
            // 
            this.AuthenticationLbl.AutoSize = true;
            this.AuthenticationLbl.Location = new System.Drawing.Point(245, 105);
            this.AuthenticationLbl.Name = "AuthenticationLbl";
            this.AuthenticationLbl.Size = new System.Drawing.Size(137, 17);
            this.AuthenticationLbl.TabIndex = 6;
            this.AuthenticationLbl.Text = "Authentication code:";
            // 
            // AuthenticationBtn
            // 
            this.AuthenticationBtn.Location = new System.Drawing.Point(248, 153);
            this.AuthenticationBtn.Name = "AuthenticationBtn";
            this.AuthenticationBtn.Size = new System.Drawing.Size(210, 43);
            this.AuthenticationBtn.TabIndex = 7;
            this.AuthenticationBtn.Text = "Check";
            this.AuthenticationBtn.UseVisualStyleBackColor = true;
            this.AuthenticationBtn.Click += new System.EventHandler(this.AuthenticationBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendBtn);
            this.panel1.Controls.Add(this.UsernameTxtBox);
            this.panel1.Controls.Add(this.UsernameLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 345);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AuthenticationTxtBox);
            this.panel2.Controls.Add(this.AuthenticationBtn);
            this.panel2.Controls.Add(this.AuthenticationLbl);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 341);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ChangePasswordBtn);
            this.panel3.Controls.Add(this.ShowEmailLbl);
            this.panel3.Controls.Add(this.EmailTextLbl);
            this.panel3.Controls.Add(this.ShowUsernameLbl);
            this.panel3.Controls.Add(this.NewPasswordBox);
            this.panel3.Controls.Add(this.NewPasswordLbl);
            this.panel3.Controls.Add(this.UsernameTextLbl);
            this.panel3.Location = new System.Drawing.Point(-6, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 345);
            this.panel3.TabIndex = 10;
            // 
            // UsernameTextLbl
            // 
            this.UsernameTextLbl.AutoSize = true;
            this.UsernameTextLbl.Location = new System.Drawing.Point(124, 105);
            this.UsernameTextLbl.Name = "UsernameTextLbl";
            this.UsernameTextLbl.Size = new System.Drawing.Size(77, 17);
            this.UsernameTextLbl.TabIndex = 0;
            this.UsernameTextLbl.Text = "Username:";
            // 
            // NewPasswordLbl
            // 
            this.NewPasswordLbl.AutoSize = true;
            this.NewPasswordLbl.Location = new System.Drawing.Point(124, 252);
            this.NewPasswordLbl.Name = "NewPasswordLbl";
            this.NewPasswordLbl.Size = new System.Drawing.Size(104, 17);
            this.NewPasswordLbl.TabIndex = 1;
            this.NewPasswordLbl.Text = "New Password:";
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(234, 247);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(264, 22);
            this.NewPasswordBox.TabIndex = 3;
            // 
            // ShowUsernameLbl
            // 
            this.ShowUsernameLbl.AutoSize = true;
            this.ShowUsernameLbl.Location = new System.Drawing.Point(240, 105);
            this.ShowUsernameLbl.Name = "ShowUsernameLbl";
            this.ShowUsernameLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowUsernameLbl.TabIndex = 4;
            this.ShowUsernameLbl.Text = "...";
            // 
            // EmailTextLbl
            // 
            this.EmailTextLbl.AutoSize = true;
            this.EmailTextLbl.Location = new System.Drawing.Point(124, 166);
            this.EmailTextLbl.Name = "EmailTextLbl";
            this.EmailTextLbl.Size = new System.Drawing.Size(106, 17);
            this.EmailTextLbl.TabIndex = 5;
            this.EmailTextLbl.Text = "E-mail address:";
            // 
            // ShowEmailLbl
            // 
            this.ShowEmailLbl.AutoSize = true;
            this.ShowEmailLbl.Location = new System.Drawing.Point(240, 166);
            this.ShowEmailLbl.Name = "ShowEmailLbl";
            this.ShowEmailLbl.Size = new System.Drawing.Size(20, 17);
            this.ShowEmailLbl.TabIndex = 6;
            this.ShowEmailLbl.Text = "...";
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(290, 275);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(151, 46);
            this.ChangePasswordBtn.TabIndex = 7;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // ForgottenPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 367);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ForgottenPasswordForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox AuthenticationTxtBox;
        private System.Windows.Forms.Label AuthenticationLbl;
        private System.Windows.Forms.Button AuthenticationBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label UsernameTextLbl;
        private System.Windows.Forms.Label NewPasswordLbl;
        private System.Windows.Forms.Label ShowUsernameLbl;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label ShowEmailLbl;
        private System.Windows.Forms.Label EmailTextLbl;
        private System.Windows.Forms.Button ChangePasswordBtn;
    }
}