using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class UserManagementUI : Form
    {
        public UserManagementUI()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserWindow window = new AddUserWindow();
            window.ShowDialog();
        }
    }
}
