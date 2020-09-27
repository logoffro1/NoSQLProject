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

        private void button1_Click(object sender, EventArgs e)
        {
            User_Service userService = new User_Service();

            User user = new User
            {
                username = "test",
                password = "pass",
                firstName = "name",
                lastName = "lastName",
                email = "gadgasd",
                nrTickets = 150

            };
            userService.AddUser(user);
        }
    }
}
