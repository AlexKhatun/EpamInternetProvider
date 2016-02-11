using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class EfUserRepository : EfAllRepository, IUserRepository
    {
        public ICollection<User> GetAll()
        {
            return db.User.ToList();
        }

        public User GetById(int id)
        {
            return db.User.First(x => x.UserId == id);
        }

        public void Insert(User user)
        {
            db.User.Add(user);
            this.Save();
        }

        public void Update(User user)
        {
            db.Entry(user).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.User.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
