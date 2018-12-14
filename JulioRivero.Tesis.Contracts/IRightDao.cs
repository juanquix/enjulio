using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.Contracts
{
    public interface IRightDao
    {
        void Create(Right right);
        void Update(Right right);
        void Delete(Right right);
        Right GetForId(int id);
        ICollection<Right> GetAll();
    }
}
