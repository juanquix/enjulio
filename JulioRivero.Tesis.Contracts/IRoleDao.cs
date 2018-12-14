using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IRoleDao
    {
        void Create(Role roles);
        void Update(Role roles);
        void Delete(Role roles);
        Role GetForId(int id);
        ICollection<Role> GetAll();
    }
}
