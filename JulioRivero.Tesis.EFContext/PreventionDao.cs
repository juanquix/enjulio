using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.EFContext
{
    public class PreventionDao: IPreventionDao
    {
        public void Create(Prevention prevention)
        {
            using (var context = new TesisContext())
            {
                context.Preventions.Add(prevention);
                context.SaveChanges();
            }
        }

        public void Delete(Prevention prevention)
        {
            using (var context = new TesisContext())
            {
                var preventionDelete = context.Preventions.SingleOrDefault(r => r.Id == prevention.Id);
                context.Preventions.Remove(preventionDelete);
                context.SaveChanges();
            }
        }

        public ICollection<Prevention> GetAll()
        {
            List<Prevention> preventions;
            using (var context = new TesisContext())
            {
                preventions = context.Preventions.ToList();
            }
            return preventions;
        }

        public Prevention GetForId(int id)
        {
            Prevention prevention;
            using (var context = new TesisContext())
            {
                prevention = context.Preventions.SingleOrDefault(r => r.Id == id);
            }
            return prevention;
        }

        public void Update(Prevention prevention)
        {
            using (var context = new TesisContext())
            {
                var preventionUpdate = context.Preventions.SingleOrDefault(r => r.Id == prevention.Id);
                if (preventionUpdate != null)
                {
                    preventionUpdate.Kind = prevention.Kind;
                    preventionUpdate.Name = prevention.Name;
                    preventionUpdate.Description = prevention.Description;
                    preventionUpdate.VisitCount = prevention.VisitCount;
                }
                context.SaveChanges();
            }
        }
    }
}
