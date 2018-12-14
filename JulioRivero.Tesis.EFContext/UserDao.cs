using JulioRivero.Tesis.Contracts;
using JulioRivero.Tesis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulioRivero.Tesis.EFContext
{
    public class UserDao: IUserDao
    {
        public void Create(User user)
        {
            using (var context = new TesisContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public void Delete(User user)
        {
            using (var context = new TesisContext())
            {
                var userDelete = context.Users.SingleOrDefault(r => r.Id == user.Id);
                context.Users.Remove(userDelete);
                context.SaveChanges();
            }
        }

        public ICollection<User> GetAll()
        {
            List<User> users;
            using (var context = new TesisContext())
            {
                users = context.Users.ToList();
            }
            return users;
        }

        public User GetForId(int id)
        {
            User user;
            using (var context = new TesisContext())
            {
                user = context.Users.SingleOrDefault(r => r.Id == id);
            }
            return user;
        }

        public void Update(User user)
        {
            using (var context = new TesisContext())
            {
                var userUpdate = context.Users.SingleOrDefault(r => r.Id == user.Id);
                if (userUpdate != null)
                {
                    userUpdate.FirstName = user.FirstName;
                    userUpdate.SecondName = user.SecondName;
                    userUpdate.LastName = user.LastName;
                    userUpdate.Telefono = user.Telefono;
                    userUpdate.Email = user.Email;
                    userUpdate.Ci = user.Ci;
                }
                context.SaveChanges();
            }
        }
    }
}
