using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IIntoPreventionDao
    {
        void Create(IntoPrevention intoPrevention);
        void Update(IntoPrevention intoPrevention);
        void Delete(IntoPrevention intoPrevention);
        IntoPrevention GetForId(int id);
        ICollection<IntoPrevention> GetAll();
    }
}
