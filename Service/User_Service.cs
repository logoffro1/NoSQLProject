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
        public void AddUser(User user)
        {
            User_DAO userDAO = new User_DAO();
            userDAO.AddUser(user);
        }
    }
}
