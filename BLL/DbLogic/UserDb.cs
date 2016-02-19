using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Security;
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

        public bool Insert(User user)
        {
            try
            {
                userDb.GetAll().First(x => x.Email == user.Email);
                return false;
            }
            catch (InvalidOperationException)
            {
                user.RegisterDate = DateTime.Now;
                user.IsDeleted = false;
                user.IsRegister = false;
                user.RoleId = 2;
                user.Password = PasswordHasher.HashPassword(user.Password);
                userDb.Insert(user);
                return true;
            }      
        }

        public bool Update(User user)
        {
            try
            {
                user.Password = PasswordHasher.HashPassword(user.Password);
                userDb.Update(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var user = userDb.GetById(id);
            try
            {
                user.IsDeleted = true;
                this.Update(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            userDb.Save();
        }
    }
}
