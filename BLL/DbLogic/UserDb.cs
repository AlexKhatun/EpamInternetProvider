using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;
using DAL.Abstract;
using DAL.Concrete;
using Ninject;

namespace BLL.DbLogic
{
    public class UserDb : BaseDb
    {
        private readonly IUserRepository userDb;

        public UserDb()
        {
            userDb = repository.AppKernel.Get<EfUserRepository>();
        }

        public ICollection<User> GetAll()
        {
            return userDb.GetAll();
        }

        public User GetById(int id)
        {
            return userDb.GetById(id);
        }

        public void Insert(User user)
        {
            userDb.Insert(user);
        }

        public void Update(User user)
        {
            userDb.Update(user);
        }

        public void Delete(int id)
        {
            userDb.Delete(id);
        }

        public void Save()
        {
            userDb.Save();
        }
    }
}
