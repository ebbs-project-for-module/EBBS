using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBS.Data;

namespace EBBS.Services.IService
{
    public interface ISecurityQuestionService
    {
        IList<SecurityQuestion> GetAllSecurityQuestions();

        SecurityQuestion GetSecurityQuestion(int sqid);

        bool AddSecurityQuestion(SecurityQuestion securityQuestion);

        bool EditSecurityQuestion(SecurityQuestion newSecurityQuestion, int sqid);

        bool DeleteSecurityQuestion(int sqid);

    }
}
