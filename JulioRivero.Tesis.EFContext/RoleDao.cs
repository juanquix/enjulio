using JulioRivero.Tesis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JulioRivero.Tesis.Entities;

namespace JulioRivero.Tesis.EFContext
{
    public class RoleDao : IRoleDao
    {
        public void Create(Role role)
        {
            using (var context = new TesisContext())
            {
                context.Roles.Add(role);
                context.SaveChanges();
            }
        }

        public void Delete(Role role)
        {
            using (var context = new TesisContext())
            {
                var roleDelete = context.Roles.SingleOrDefault(r => r.Id == role.Id);
                context.Roles.Remove(roleDelete);
                context.SaveChanges();
            }
        }

        public ICollection<Role> GetAll()
        {
            List<Role> roles;
            using (var context = new TesisContext())
            {
                roles = context.Roles.ToList();
            }
            return roles;
        }

        public Role GetForId(int id)
        {
            Role role;
            using (var context = new TesisContext())
            {
                role = context.Roles.SingleOrDefault(r => r.Id == id);
            }
            return role;
        }

        public void Update(Role role)
        {
            using (var context = new TesisContext())
            {
                var roletUpdate = context.Roles.SingleOrDefault(r => r.Id == role.Id);
                if (roletUpdate != null)
                {
                    roletUpdate.Name = role.Name;
                }
                context.SaveChanges();
            }
        }
    }
}
