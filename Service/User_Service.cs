using System;
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
    }
}
