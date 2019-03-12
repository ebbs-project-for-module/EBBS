using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBS.Data;
using EBBS.Data.DAO;
using EBBS.Data.IDAO;
using EBBS.Services.IService;

namespace EBBS.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        private int userId;

        public UserService() {
            userDAO = new UserDAO();
        }


        public bool AddUser(User user)
        {
            if (userDAO.AddUser(user)) {
                return true;
            } else {
                return false;
            }
        }

        //public bool ChangePassword(int userId, string newPassword)
        //{
        //    if (userDAO.ChangePassword(userId, newPassword))
        //    {
        //        return true;
        //    }
        //    else {
        //        return false;
        //    }
        //}

        public bool DeleteUser(int userId)
        {
            if (userDAO.DeleteUser(userId))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool EditUser(User newUser, int userId)
        {
            if (userDAO.EditUser(newUser, userId))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public IList<User> GetAllUsers()
        {
            return userDAO.GetAllUsers();
        }

        public User GetUser(int userId)
        {
            return userDAO.GetUser(userId);
        }
    }
}
