using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Data.IDAO
{
    public interface ISecurityQuestionDAO
    {

        IList<EBBS.Data.SecurityQuestion> GetAllSecurityQuestions();

        EBBS.Data.SecurityQuestion GetSecurityQuestion(int sqid);

        bool AddSecurityQuestion(EBBS.Data.SecurityQuestion securityQuestion);

        bool EditSecurityQuestion(EBBS.Data.SecurityQuestion newSecurityQuestion, int sqid);

        bool DeleteSecurityQuestion(int sqid);
    }
}
