﻿using Model;
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
        List<User> allUsers;

        public AddUserWindow()
        {
            InitializeComponent();
            service = new User_Service();
            allUsers = new List<User>();
        }
        private void AddUserWindow_Load(object sender, EventArgs e)
        {
            
        }

        //Adds a new user.
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (isUserValid())
            {
                User newUser = new User(txtUsername.Text,txtPassword.Text,txtName.Text,txtlastName.Text,txtEmailAddress.Text,0);
                try
                {
                    service.AddUser(newUser);
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                MessageBox.Show($"{newUser.firstName} {newUser.lastName} is added as a new user.","Welcome aboard!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ClearFields();
            }

        }

        private bool isUserValid()
        {
            if (service.IsUsernamePresent(txtUsername.Text))
            {
                MessageBox.Show("Username is already taken please pick another one","Invalid username",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            else if(String.IsNullOrWhiteSpace(txtUsername.Text)||String.IsNullOrWhiteSpace(txtPassword.Text)||String.IsNullOrWhiteSpace(txtName.Text)||String.IsNullOrWhiteSpace(txtEmailAddress.Text)||String.IsNullOrWhiteSpace(txtlastName.Text))
            {
                MessageBox.Show("Please fill all the fields properly(all fields must be filled","Missing field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(txtPassword.Text.Length<4 || txtUsername.Text.Length < 4)
            {
                MessageBox.Show("Username and password field must have more than 4 characters","Invalid username/password",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }



        private void ClearFields()
        {
            txtName.Clear();
            txtlastName.Clear();
            txtEmailAddress.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
