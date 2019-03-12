using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBBS.Data;

namespace EBBS.Data.IDAO
{
    public interface IRoleDao
    {
        IList<Role> GetAllRoles();

        bool AddRole(Role role);
        bool DeleteRole(int id);

        bool EditRole(Role newRole, int id);

        Role GetRoles(int id);
    }
}
