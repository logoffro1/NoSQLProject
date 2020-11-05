using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;

namespace NoSQLProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new TicketsOverview().Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserManagementUI().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();
            new Dashboard(userService.GetUserById(1)).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void buttonConfigItem_Click(object sender, EventArgs e)
        {
            new ConfigItemUi().Show();
            this.Hide();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            new Archive_View().Show();
            this.Hide();
        }
    }
}