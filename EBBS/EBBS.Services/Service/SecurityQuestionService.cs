using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBS.Data;
using EBBS.Data.DAO;
using EBBS.Data.IDAO;

namespace EBBS.Services.Service
{
    public class SecurityQuestionService : EBBS.Services.IService.ISecurityQuestionService
    {
        private ISecurityQuestionDAO securityQuestionDAO;

        public SecurityQuestionService() {
            securityQuestionDAO = new SecurityQuestionDAO();
        }

        public bool AddSecurityQuestion(SecurityQuestion securityQuestion)
        {
            if(securityQuestionDAO.AddSecurityQuestion(securityQuestion))
            { return true; }
            else { return false; }
        }

        public bool DeleteSecurityQuestion(int sqid)
        {
            if (securityQuestionDAO.DeleteSecurityQuestion(sqid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditSecurityQuestion(SecurityQuestion newSecurityQuestion, int sqid)
        {
            if(securityQuestionDAO.EditSecurityQuestion(newSecurityQuestion, sqid))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IList<SecurityQuestion> GetAllSecurityQuestions()
        {
            return securityQuestionDAO.GetAllSecurityQuestions();
        }

        public SecurityQuestion GetSecurityQuestion(int sqid)
        {
            return securityQuestionDAO.GetSecurityQuestion(sqid);
        }
    }
}
