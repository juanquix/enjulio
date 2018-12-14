using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IUserDao
    {
        void Create(User user);
        void Update(User user);
        void Delete(User user);
        User GetForId(int id);
        ICollection<User> GetAll();
    }
}
