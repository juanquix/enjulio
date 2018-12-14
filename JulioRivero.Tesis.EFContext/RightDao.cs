using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.EFContext
{
    public class RightDao:IRightDao
    {
        public void Create(Right right)
        {
            using (var context = new TesisContext())
            {
                context.Rights.Add(right);
                context.SaveChanges();
            }
        }

        public void Delete(Right right)
        {
            using (var context = new TesisContext())
            {
                var rightDelete = context.Rights.SingleOrDefault(r => r.Id == right.Id);
                context.Rights.Remove(rightDelete);
                context.SaveChanges();
            }
        }

        public ICollection<Right> GetAll()
        {
            List<Right> rights;
            using (var context = new TesisContext())
            {
                rights = context.Rights.ToList();
            }
            return rights;
        }

        public Right GetForId(int id)
        {
            Right right;
            using (var context = new TesisContext())
            {
                right = context.Rights.SingleOrDefault(r => r.Id == id);
            }
            return right;
        }

        public void Update(Right right)
        {
            using (var context = new TesisContext())
            {
                var rightUpdate = context.Rights.SingleOrDefault(r => r.Id == right.Id);
                if (rightUpdate != null)
                {
                    rightUpdate.Title = right.Title;
                    rightUpdate.Description = right.Description;
                    rightUpdate.FilePdf = right.FilePdf;
                }
                context.SaveChanges();
            }
        }
    }
}
