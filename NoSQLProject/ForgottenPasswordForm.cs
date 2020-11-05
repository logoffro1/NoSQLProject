using Model;
using Service;
using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace NoSQLProject
{
    public partial class ForgottenPasswordForm : Form
    {
        private User selectedUser;
        private int key;
        public ForgottenPasswordForm()
        {
            
            InitializeComponent();
            panel1.Show();
            panel2.Hide();
            panel3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            selectedUser = CheckUser();
            try
            {
                key = CreateKey();
                SendMailToUser(selectedUser,key);
                
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
        private User CheckUser()
        {
            _ = new User();
            User_Service userService = new User_Service();
            if (userService.IsUsernamePresent(UsernameTxtBox.Text))
            {
                User user = userService.GetUserByName(UsernameTxtBox.Text);
                return user;
            }
            else
            {
                return null;
            }
        }
        private void SendMailToUser(User user,int key)
        {
            if (user != null){
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("nosql2020project@gmail.com");
                    mail.To.Add(user.email);
                    mail.Subject = "Password recovery";
                    mail.Body = "<h3> Your authentication key is: </h3><mark>" + key.ToString() + "</mark>";
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("nosql2020project@gmail.com", "Project123!");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                    }
                }
                label1.Text = "";
                panel1.Hide();
                panel2.Show();
            }
            else
            {
                label1.Text = "Something went wrong!";
            }
        }
        private int CreateKey()
        {
         RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] byteArray = new byte[4];
            rng.GetBytes(byteArray);
            int value = BitConverter.ToInt32(byteArray, 0);
            return value;
        }

        private void AuthenticationBtn_Click(object sender, EventArgs e)
        {
            if(AuthenticationTxtBox.Text == key.ToString())
            {
                panel2.Hide();
                panel3.Show();
                ShowUsernameLbl.Text = selectedUser.username;
                ShowEmailLbl.Text = selectedUser.email;
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            User_Service service = new User_Service();
            if (NewPasswordBox.Text.Length < 4)
            {
                MessageBox.Show("Invalid password! Must contain 4 or more symbols");
            }
            else
            {
                service.UpdateUserPassword(selectedUser, NewPasswordBox.Text);
                this.Close();
                MessageBox.Show("Password changed successfully!");
                
            }
        }
    }
}
