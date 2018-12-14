using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Biz
{
    public class UserManager
    {
        private IUserDao _userDao;
        public UserManager(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public User StoreUser(User user)
        {
            if (user != null)
            {
                if (user.Id == 0)
                {
                    _userDao.Create(user);
                }
                else
                {
                    _userDao.Update(user);
                }
            }
            return user;
        }
        public User GetById(int id)
        {
            return _userDao.GetForId(id);
        }
        public bool DeleteUser(int id)
        {
            var user = _userDao.GetForId(id);
            // _deficiencyDao.Update(deficiency);
            _userDao.Delete(user);
            return true;
        }

        public List<User> GetAllUsers()
        {
            var users = _userDao.GetAll().ToList();
            //controlar estados 
            return users;
        }
    }
}
