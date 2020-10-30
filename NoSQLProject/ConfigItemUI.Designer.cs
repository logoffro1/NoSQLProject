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
            this.listViewConfigurationItems = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImportance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.textBoxFilterCI.TextChanged += new System.EventHandler(this.textBoxFilterCI_TextChanged);
            this.textBoxFilterCI.Click += new System.EventHandler(this.textBoxFilterCI_Click);
            // 
            // listViewConfigurationItems
            // 
            this.listViewConfigurationItems.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewConfigurationItems.AllowColumnReorder = true;
            this.listViewConfigurationItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderName,
            this.columnHeaderDescription,
            this.columnHeaderOwner,
            this.columnHeaderLocation,
            this.columnHeaderImportance});
            this.listViewConfigurationItems.FullRowSelect = true;
            this.listViewConfigurationItems.GridLines = true;
            this.listViewConfigurationItems.HideSelection = false;
            this.listViewConfigurationItems.Location = new System.Drawing.Point(12, 38);
            this.listViewConfigurationItems.MultiSelect = false;
            this.listViewConfigurationItems.Name = "listViewConfigurationItems";
            this.listViewConfigurationItems.Size = new System.Drawing.Size(776, 343);
            this.listViewConfigurationItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewConfigurationItems.TabIndex = 2;
            this.listViewConfigurationItems.UseCompatibleStateImageBehavior = false;
            this.listViewConfigurationItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 25;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            // 
            // columnHeaderOwner
            // 
            this.columnHeaderOwner.Text = "Owner";
            // 
            // columnHeaderLocation
            // 
            this.columnHeaderLocation.Text = "Location";
            // 
            // columnHeaderImportance
            // 
            this.columnHeaderImportance.Text = "Importance";
            this.columnHeaderImportance.Width = 121;
            // 
            // ConfigItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewConfigurationItems);
            this.Controls.Add(this.textBoxFilterCI);
            this.Controls.Add(this.NewConfigItem);
            this.Name = "ConfigItemUi";
            this.Text = "ConfigItemUI";
            this.Load += new System.EventHandler(this.ConfigItemUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewConfigItem;
        private System.Windows.Forms.TextBox textBoxFilterCI;
        private System.Windows.Forms.ListView listViewConfigurationItems;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderOwner;
        private System.Windows.Forms.ColumnHeader columnHeaderLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderImportance;
    }
}