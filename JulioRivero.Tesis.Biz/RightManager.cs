using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Biz
{
    public class RightManager
    {
        private IRightDao _rightDao;
        public RightManager(IRightDao rightDao)
        {
            _rightDao = rightDao;
        }

        public Right StoreRight(Right right)
        {
            if (right != null)
            {
                if (right.Id == 0)
                {
                    _rightDao.Create(right);
                }
                else
                {
                    _rightDao.Update(right);
                }
            }
            return right;
        }
        public Right GetById(int id)
        {
            return _rightDao.GetForId(id);
        }
        public bool DeleteRight(int id)
        {
            var right = _rightDao.GetForId(id);
            // _deficiencyDao.Update(deficiency);
            _rightDao.Delete(right);
            return true;
        }

        public List<Right> GetAllRights()
        {
            var rights = _rightDao.GetAll().ToList();
            //controlar estados 
            return rights;
        }
    }
}
