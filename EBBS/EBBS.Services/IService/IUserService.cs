using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBS.Data;

namespace EBBS.Services.IService
{
    public interface IUserService
    {
        IList<User> GetAllUsers();

        User GetUser(int userId);

        bool AddUser(User user);

        bool EditUser(User newUser, int userId);

        bool DeleteUser(int userId);

        //bool ChangePassword(int userId, string newPassword);
      
    }
}
