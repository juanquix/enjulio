using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Biz
{
    public class RoleManager
    {
        private IRoleDao _roleDao;
        public RoleManager(IRoleDao roleDao)
        {
            _roleDao = roleDao;
        }

        public Role StoreRole(Role role)
        {
            if (role != null)
            {
                if (role.Id == 0)
                {
                    _roleDao.Create(role);
                }
                else
                {
                    _roleDao.Update(role);
                }
            }
            return role;
        }
        public Role GetById(int id)
        {
            return _roleDao.GetForId(id);
        }
        public bool DeleteRole(int id)
        {
            var role = _roleDao.GetForId(id);
            // _deficiencyDao.Update(deficiency);
            _roleDao.Delete(role);
            return true;
        }

        public List<Role> GetAllRoles()
        {
            var roles = _roleDao.GetAll().ToList();
            //controlar estados 
            return roles;
        }
    }
}
