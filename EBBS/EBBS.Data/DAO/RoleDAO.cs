using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBBS.Data.DAO
{
    public class RoleDAO
    {
        private ebbsEntities _context;

        public RoleDAO()
        {
            _context=new  ebbsEntities();
        }

        public bool AddRole(Role role)
        {
            try
            {
                _context.Role.Add(role);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.Write(e.ToString());
                return false;


            }
        }

        public bool DeleteRole(int id)

        {
            Role roleDelete = _context.Role.Where(x => x.rId == id).First();
            try
            {
                _context.Role.Remove(roleDelete);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return false;
            }
        }

        public bool EditRole(Role newRole, int id)
        {
            Role roleEdit = _context.Role.Where(x => x.rId == id).First();
            roleEdit.roleName = newRole.roleName;

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string error = e.ToString();
                return false;
            }

        }

        public IList<Role> GetAllRoles()
        {
            IQueryable<Role> roles = from roleType
                                     in _context.Role
                                     select roleType;

            return roles.ToList<Role>();

        }

        public Role GetRoles(int id)
        {
            Role getRole = _context.Role.Where(x => x.rId == id).First();
            return getRole;
        }
    }
}

