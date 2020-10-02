namespace NoSQLProject
{
    partial class UserManagementUI
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
            this.userView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(607, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Users";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // userView
            // 
            this.userView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Tickets});
            this.userView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userView.HideSelection = false;
            this.userView.Location = new System.Drawing.Point(12, 89);
            this.userView.Name = "userView";
            this.userView.Size = new System.Drawing.Size(776, 349);
            this.userView.TabIndex = 2;
            this.userView.UseCompatibleStateImageBehavior = false;
            this.userView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Email
            // 
            this.Email.Text = "Email address";
            this.Email.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First name";
            this.FirstName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.Text = "Last name";
            this.LastName.Width = 200;
            // 
            // Tickets
            // 
            this.Tickets.Text = "#Tickets";
            this.Tickets.Width = 200;
            // 
            // UserManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userView);
            this.Controls.Add(this.btnAdd);
            this.Name = "UserManagementUI";
            this.Text = "UserManagementUI";
            this.Load += new System.EventHandler(this.UserManagementUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView userView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Tickets;
    }
}