﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;
namespace Service
{
    public class User_Service
    {
        User_DAO userDAO = new User_DAO();

        public void AddUser(User user)
        {
            userDAO.AddUser(user);
        }
        public bool IsUsernamePresent(string username)
        {
            return userDAO.IsUsernamePresent(username);
        }
        public List<User> getAllUsers()
        {
            return userDAO.getAllUsers();
        }
        public void UpdateUserTickets(User newUser)
        {
            userDAO.UpdateUserTickets(newUser);
        }
        public User GetUserById(int id)
        {
            return userDAO.GetUserById(id);
        }
        public User GetUserByName(string username)
        {
            return userDAO.GetUserByName(username);
        }
    }
}
