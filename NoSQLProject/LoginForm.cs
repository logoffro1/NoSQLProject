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

        public LoginForm(User user)                         // for remember me
        {
            InitializeComponent();
            PasswordTxtBox.PasswordChar = '●';
            UsernameTxtBox.Text = user.username;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            _ = new User();
            User_Service userService = new User_Service();
            if ((UsernameTxtBox.Text.Length < 1) || (PasswordTxtBox.Text.Length < 1))
            {
                label1.Text = "Missing credentials";
            }
            else
            {
                if (userService.IsUsernamePresent(UsernameTxtBox.Text))
                {
                    User user = userService.GetUserByName(UsernameTxtBox.Text);
                    if (PasswordTxtBox.Text.Equals(user.password))
                    {
                        this.Hide();
                        new Form1().Show();
                    }
                    else
                    {
                        label1.Text = "Incorrect username or password";
                    }
                }
                else
                {
                    label1.Text = "Username does not exist";
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordLbl_Click(object sender, EventArgs e)
        {
            ForgottenPasswordForm passwordForm = new ForgottenPasswordForm();
            passwordForm.Show();
        }
    }
}
