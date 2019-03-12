using EBBS.Data.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Data.DAO
{
    public class SecurityQuestionDAO : ISecurityQuestionDAO
    {

        private ebbsEntities _context;

        public SecurityQuestionDAO() {
            _context = new ebbsEntities();
        }

        public bool AddSecurityQuestion(SecurityQuestion securityQuestion)
        {
            try {
                _context.SecurityQuestion.Add(securityQuestion);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.Write(e.ToString());
                    return false;
                    

            }
        }

        public bool DeleteSecurityQuestion(int sqid)

        {
            SecurityQuestion security_question = _context.SecurityQuestion.Where(x => x.qId == sqid).First();
            try { _context.SecurityQuestion.Remove(security_question);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return false;
            }
        }

        public bool EditSecurityQuestion(SecurityQuestion newSecurityQuestion, int sqid)
        {
            SecurityQuestion oldSecurityQuestion = _context.SecurityQuestion.Where(x => x.qId == sqid).First();
            oldSecurityQuestion.question = newSecurityQuestion.question;

            try { _context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                string error = e.ToString();
                return false;
            }

        }

        public IList<SecurityQuestion> GetAllSecurityQuestions()
        {
            IQueryable<SecurityQuestion> securityQuestions = from catQuestion
                                                             in _context.SecurityQuestion
                                                             select catQuestion;

            return securityQuestions.ToList<SecurityQuestion>();
           
        }

        public SecurityQuestion GetSecurityQuestion(int sqid)
        {
            SecurityQuestion getSecurityQuestion = _context.SecurityQuestion.Where(x => x.qId == sqid).First();
            return getSecurityQuestion;
        }
    }
}
