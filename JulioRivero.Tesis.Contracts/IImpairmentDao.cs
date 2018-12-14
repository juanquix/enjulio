using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JulioRivero.Tesis.Contracts
{
    public interface IImpairmentDao
    {
        void Create(Impairment imparirment);
        void Update(Impairment imparirment);
        void Delete(Impairment imparirment);
        Impairment GetForId(int id);
        ICollection<Impairment> GetAll();
    }
}
