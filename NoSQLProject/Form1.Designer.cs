﻿namespace NoSQLProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonConfigItem = new System.Windows.Forms.Button();
            this.buttonArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ticket overview (temp)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(112, 0);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(107, 55);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "User overview (temp)";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dashboard (temp)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Login (temp)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonConfigItem
            // 
            this.buttonConfigItem.Location = new System.Drawing.Point(0, 59);
            this.buttonConfigItem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfigItem.Name = "buttonConfigItem";
            this.buttonConfigItem.Size = new System.Drawing.Size(107, 56);
            this.buttonConfigItem.TabIndex = 4;
            this.buttonConfigItem.Text = "Configuration Item (temp)";
            this.buttonConfigItem.UseVisualStyleBackColor = true;
            this.buttonConfigItem.Click += new System.EventHandler(this.buttonConfigItem_Click);
            // 
            // buttonArchive
            // 
            this.buttonArchive.Location = new System.Drawing.Point(112, 59);
            this.buttonArchive.Name = "buttonArchive";
            this.buttonArchive.Size = new System.Drawing.Size(107, 56);
            this.buttonArchive.TabIndex = 5;
            this.buttonArchive.Text = "Archive Config Item older 10 days";
            this.buttonArchive.UseVisualStyleBackColor = true;
            this.buttonArchive.Click += new System.EventHandler(this.buttonArchive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 297);
            this.Controls.Add(this.buttonArchive);
            this.Controls.Add(this.buttonConfigItem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonConfigItem;
        private System.Windows.Forms.Button buttonArchive;
    }
}

