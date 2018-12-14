using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IPreventionDao
    {
        void Create(Prevention prevention);
        void Update(Prevention prevention);
        void Delete(Prevention prevention);
        Prevention GetForId(int id);
        ICollection<Prevention> GetAll();
    }
}
