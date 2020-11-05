namespace NoSQLProject
{
    partial class ConfigItemUi
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
            this.textBoxFilterCI = new System.Windows.Forms.TextBox();
            this.buttonEditConfigItem = new System.Windows.Forms.Button();
            this.dataGridViewConfigItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigItem)).BeginInit();
            this.SuspendLayout();
            // 
            // NewConfigItem
            // 
            this.NewConfigItem.Location = new System.Drawing.Point(12, 387);
            this.NewConfigItem.Name = "NewConfigItem";
            this.NewConfigItem.Size = new System.Drawing.Size(111, 51);
            this.NewConfigItem.TabIndex = 3;
            this.NewConfigItem.Text = "Add New Configuration Item";
            this.NewConfigItem.UseVisualStyleBackColor = true;
            this.NewConfigItem.Click += new System.EventHandler(this.NewConfigItem_Click);
            // 
            // textBoxFilterCI
            // 
            this.textBoxFilterCI.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilterCI.Name = "textBoxFilterCI";
            this.textBoxFilterCI.Size = new System.Drawing.Size(196, 20);
            this.textBoxFilterCI.TabIndex = 1;
            this.textBoxFilterCI.Text = "Filter Items...";
            this.textBoxFilterCI.Click += new System.EventHandler(this.textBoxFilterCI_Click);
            this.textBoxFilterCI.TextChanged += new System.EventHandler(this.textBoxFilterCI_TextChanged);
            // 
            // buttonEditConfigItem
            // 
            this.buttonEditConfigItem.Location = new System.Drawing.Point(129, 387);
            this.buttonEditConfigItem.Name = "buttonEditConfigItem";
            this.buttonEditConfigItem.Size = new System.Drawing.Size(111, 51);
            this.buttonEditConfigItem.TabIndex = 4;
            this.buttonEditConfigItem.Text = "Edit Selected Configuration Item";
            this.buttonEditConfigItem.UseVisualStyleBackColor = true;
            this.buttonEditConfigItem.Click += new System.EventHandler(this.buttonEditConfigItem_Click);
            // 
            // dataGridViewConfigItem
            // 
            this.dataGridViewConfigItem.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewConfigItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConfigItem.Location = new System.Drawing.Point(12, 38);
            this.dataGridViewConfigItem.Name = "dataGridViewConfigItem";
            this.dataGridViewConfigItem.ReadOnly = true;
            this.dataGridViewConfigItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewConfigItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewConfigItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConfigItem.Size = new System.Drawing.Size(776, 343);
            this.dataGridViewConfigItem.TabIndex = 5;
            this.dataGridViewConfigItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConfigItem_CellContentClick);
            // 
            // ConfigItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewConfigItem);
            this.Controls.Add(this.buttonEditConfigItem);
            this.Controls.Add(this.textBoxFilterCI);
            this.Controls.Add(this.NewConfigItem);
            this.Name = "ConfigItemUi";
            this.Text = "ConfigItemUI";
            this.Load += new System.EventHandler(this.ConfigItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConfigItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewConfigItem;
        private System.Windows.Forms.TextBox textBoxFilterCI;
        private System.Windows.Forms.Button buttonEditConfigItem;
        private System.Windows.Forms.DataGridView dataGridViewConfigItem;
    }
}