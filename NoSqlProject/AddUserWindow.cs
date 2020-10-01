using Service;
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
    public partial class AddUserWindow : Form
    {
        User_Service service;

        public AddUserWindow()
        {
            InitializeComponent();
            service = new User_Service();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Will have add user function here

        }
    }
}
