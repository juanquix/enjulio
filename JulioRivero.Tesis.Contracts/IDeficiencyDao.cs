using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IDeficiencyDao
    {
        void Create(Deficiency deficiency);
        void Update(Deficiency deficiency);
        void Delete(Deficiency deficiency);
        Deficiency GetForId(int id);
        ICollection<Deficiency> GetAll();
    }
}
