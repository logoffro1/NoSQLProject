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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '●';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            User_Service userService = new User_Service();
            if (userService.IsUsernamePresent(UsernameTxtBox.Text))
            {
                user = userService.GetUserByName(UsernameTxtBox.Text);
                if (PasswordTxtBox.Text.Equals(user.password))
                {
                    this.Hide();
                    new Form1().Show();
                }
                else
                {
                    label1.Text = "Incorrect password";
                }
            }
            else
            {
                label1.Text = "Username does not exist";
            }

        }
        



    }
}
