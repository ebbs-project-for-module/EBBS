using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Data.IDAO
{
    public interface IUserDAO
    {

        IList<EBBS.Data.User> GetAllUsers();

        EBBS.Data.User GetUser(int userId);

        bool AddUser(EBBS.Data.User user);

        bool EditUser(EBBS.Data.User newUser, int userId);

        bool DeleteUser(int userId);

        //bool ChangePassword(int userId, string newPassword);
       
    }
}
