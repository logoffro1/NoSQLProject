namespace NoSQLProject
{
    partial class ConfigItemUI
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
            this.NewConfigItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewConfigItem
            // 
            this.NewConfigItem.Location = new System.Drawing.Point(12, 387);
            this.NewConfigItem.Name = "NewConfigItem";
            this.NewConfigItem.Size = new System.Drawing.Size(111, 51);
            this.NewConfigItem.TabIndex = 0;
            this.NewConfigItem.Text = "Add New Configuration Item";
            this.NewConfigItem.UseVisualStyleBackColor = true;
            this.NewConfigItem.Click += new System.EventHandler(this.NewConfigItem_Click);
            // 
            // ConfigItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewConfigItem);
            this.Name = "ConfigItemUI";
            this.Text = "ConfigItemUI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewConfigItem;
    }
}