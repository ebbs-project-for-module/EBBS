using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EBBS.Data;
using EBBS.Services.Service;

namespace EBBS.Controllers
{
    public class UsersController : ApiController
    {

        private EBBS.Services.IService.IUserService userService;

        
        public UsersController()
        {
            userService = new EBBS.Services.Service.UserService();
        }

        // GET: api/Users


        public HttpResponseMessage Get()
        {
            IEnumerable<User> allUsers = userService.GetAllUsers();
            if (allUsers == null)
            {
                HttpResponseMessage nullResponse = Request.CreateResponse(HttpStatusCode.NotFound);
                return nullResponse;
            }
            else
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, allUsers);
                return goodResponse;
            }
        }

        // GET: api/Users/5
        public HttpResponseMessage Get(int id)
        {
            User singleUser = userService.GetUser(id);
            
            if (singleUser == null)
            {
                HttpResponseMessage nullResponse = Request.CreateResponse(HttpStatusCode.NotFound);
                return nullResponse;
            }
            else
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, singleUser);
                return goodResponse;
            }


        }

        // POST: api/Users
        public HttpResponseMessage Post(User addUserDetails)
        {
            if (userService.AddUser(addUserDetails))
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, addUserDetails.userId);
                return goodResponse;
            }
            else
            {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.NotFound, addUserDetails);
                return badResponse;
            }

        }

        // PUT: api/Users/5
        public HttpResponseMessage Put(int id, User editUserDetails)
        {
            if (userService.EditUser(editUserDetails, id))
            {

                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, id);
                return goodResponse;
            }
            else
            {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.BadRequest, id);
                return badResponse;
            }



        }

        // PUT: api/Users/5
        //public HttpResponseMessage Put(int id, string password, User changePassword)
        //{
        //    if (userService.ChangePassword(changePassword, id))
        //    {

        //        HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, id);
        //        return goodResponse;
        //    }
        //    else
        //    {
        //        HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.BadRequest, id);
        //        return badResponse;
        //    }



        //}



        // DELETE: api/Users/5
        public HttpResponseMessage Delete(int id)
        {
            if (userService.DeleteUser(id))
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, "You successfully deleted the User");
                return goodResponse;
            }
            else
            {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.BadRequest, id);
                return badResponse;
            }


        }
    }
}
