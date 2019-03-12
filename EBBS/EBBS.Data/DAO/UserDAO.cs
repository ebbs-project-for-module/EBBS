using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Data.DAO
{
    public class UserDAO : IDAO.IUserDAO
    {
        private ebbsEntities context;
        private int userId;

        public UserDAO() {
            context = new ebbsEntities();
        }


        public bool AddUser(User user)
        {
            try
            {
                context.User.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                Console.Out.Write(e.ToString());
                return false;
            }
        }

        //public bool ChangePassword(int userId, string newPassword)
        //{
        //    User user = context.User.Where(x => x.userId == userId).First();
        //    user.password = newPassword;
        //    try
        //    {
        //        context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception e) {
        //        string error = e.ToString();
        //        return false;
        //    }

        //}



        public bool DeleteUser(int userId)
        {
            User user = context.User.Where(x => x.userId == userId).First();

            try
            {
                context.User.Remove(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                string error = e.ToString();
                return false;
            }
        }

        public bool EditUser(User newUser, int userId)
        {
            User oldUser = context.User.Where(x => x.userId == userId).First();
            oldUser.userImage = newUser.userImage;
            oldUser.password = newUser.password;
            oldUser.lastName = newUser.lastName;
            oldUser.questionId = newUser.questionId;
            oldUser.answer = newUser.answer;
            oldUser.firstName = newUser.firstName;
            oldUser.username = newUser.username;
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception e) {
                return false;
            }

        }

        public IList<User> GetAllUsers()
        {
            IQueryable<User> allUsers = from user
                                        in context.User
                                        select user;
            if (allUsers != null)
            {
                return allUsers.ToList<User>();
            }
            else {
                return null;
            }
        }

        public User GetUser(int userId)
        {
            User myUser = context.User.Where(x => x.userId == userId).First();
            return myUser;
        }
    }
}
