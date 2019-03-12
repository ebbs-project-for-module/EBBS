using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EBBS.Controllers
{
    public class SQAPIController : ApiController
    {
        private EBBS.Services.IService.ISecurityQuestionService securityQuestionService;

        public SQAPIController() {
            securityQuestionService = new EBBS.Services.Service.SecurityQuestionService();
        }


        // GET: api/SQAPI
        public HttpResponseMessage Get()
        {
            IEnumerable<EBBS.Data.SecurityQuestion> allSecurityQuestions = securityQuestionService.GetAllSecurityQuestions();

            if (allSecurityQuestions == null)
            {
                HttpResponseMessage nullResponse = Request.CreateResponse(HttpStatusCode.NotFound);
                return nullResponse;
            }
            else {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, allSecurityQuestions);
                return goodResponse;

            }



        }

        // GET: api/SQAPI/5
        public HttpResponseMessage Get(int id)
        {
            EBBS.Data.SecurityQuestion securityQuestion = securityQuestionService.GetSecurityQuestion(id);

            if (securityQuestion == null)
            {
                HttpResponseMessage nullResponse = Request.CreateResponse(HttpStatusCode.NotFound);
                return nullResponse;
            }
            else {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, securityQuestion);
                return goodResponse;
            }

            
        }

        // POST: api/SQAPI
        public HttpResponseMessage Post(EBBS.Data.SecurityQuestion securityQuestion)
        {
            if (securityQuestionService.AddSecurityQuestion(securityQuestion))
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, securityQuestion.qId);
                return goodResponse;
            }
            else {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.NotFound, securityQuestion);
                return badResponse;
            }

        }

        // PUT: api/SQAPI/5
        public HttpResponseMessage Put(int id, EBBS.Data.SecurityQuestion newSecurityQuestion)
        {
            if (securityQuestionService.EditSecurityQuestion(newSecurityQuestion, id))
            {

                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, id);
                return goodResponse;
            }
            else {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.BadRequest, id);
                return badResponse;
            }



        }

        // DELETE: api/SQAPI/5
        public HttpResponseMessage Delete(int id)
        {
            if (securityQuestionService.DeleteSecurityQuestion(id))
            {
                HttpResponseMessage goodResponse = Request.CreateResponse(HttpStatusCode.OK, "You successfully deleted the security question");
                return goodResponse;
            }
            else {
                HttpResponseMessage badResponse = Request.CreateResponse(HttpStatusCode.BadRequest, id);
                return badResponse;
            }


        }
    }
}
