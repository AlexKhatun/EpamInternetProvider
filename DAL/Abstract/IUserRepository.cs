using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IUserRepository
    {
        ICollection<User> GetAll();
        User GetById(int id);
        void Insert(User user);
        void Update(User user);
        void Delete(int id);
        void Save();
    }
}
