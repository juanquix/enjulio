using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;

namespace JulioRivero.Tesis.EFContext
{
    public class ImpairmentDao : IImpairmentDao
    {
        public void Create(Impairment imparirment)
        {
            using (var context = new TesisContext())
            {
                context.Impairments.Add(imparirment);
                context.SaveChanges();
            }
        }

        public void Delete(Impairment imparirment)
        {
            using (var context = new TesisContext())
            {
                var imparirmentDelete = context.Impairments.SingleOrDefault(r => r.Id == imparirment.Id);
                context.Impairments.Remove(imparirmentDelete);
                context.SaveChanges();
            }
        }

        public ICollection<Impairment> GetAll()
        {
            List<Impairment> imparirments;
            using (var context = new TesisContext())
            {
                imparirments = context.Impairments.ToList();
            }
            return imparirments;
        }

        public Impairment GetForId(int id)
        {
            Impairment imparirment;
            using (var context = new TesisContext())
            {
                imparirment = context.Impairments.SingleOrDefault(r => r.Id == id);
            }
            return imparirment;
        }

        public void Update(Impairment imparirment)
        {
            using (var context = new TesisContext())
            {
                var imparirmentUpdate = context.Impairments.SingleOrDefault(r => r.Id == imparirment.Id);
                if (imparirmentUpdate != null)
                {
                    imparirmentUpdate.Kind = imparirment.Kind;
                    imparirmentUpdate.Name = imparirment.Name;
                    imparirmentUpdate.Description = imparirment.Description;
                    
                }
                context.SaveChanges();
            }
        }
    }
}
