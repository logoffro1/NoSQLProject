using Model;
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
    public partial class UserManagementUI : Form
    {
        List<User> allUsers;
        User_Service service;
        public UserManagementUI()
        {
            InitializeComponent();
            allUsers = new List<User>();
            service = new User_Service();
        }
        private void UserManagementUI_Load(object sender, EventArgs e)
        {
            allUsers = service.getAllUsers();
            FillListView();
        }

        private void FillListView()
        {
            userView.Clear();
            userView.Columns.Add("Id");
            userView.Columns.Add("Email address");
            userView.Columns.Add("First name");
            userView.Columns.Add("Last name");
            userView.Columns.Add("# tickets");

            foreach(User u in allUsers)
            {
                ListViewItem item = new ListViewItem(
                        new string[] {
                        u.id.ToString(),
                        u.email,
                        u.firstName,
                        u.lastName,
                        u.nrTickets.ToString()
                    });                                 
                userView.Items.Add(item);
            }

            userView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserWindow window = new AddUserWindow();
            window.ShowDialog();
            FillListView(); // fix this
        }

       
    }
}
