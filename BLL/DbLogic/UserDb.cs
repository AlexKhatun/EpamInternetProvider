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

        public string Insert(User user)
        {
            try
            {
                userDb.GetAll().First(x => x.Email == user.Email);
                return "Такой пользователь уже существует";
            }
            catch (InvalidOperationException)
            {
                user.RegisterDate = DateTime.Now;
                user.IsDeleted = false;
                user.IsRegister = false;
                user.RoleId = 2;
                user.Password = PasswordHasher.HashPassword(user.Password);
                user.Email = user.Email.ToLower();
                userDb.Insert(user);
                return "Регистрация успешна!";
            }      
        }

        public void Update(User user)
        {
            user.Password = PasswordHasher.HashPassword(user.Password);
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
