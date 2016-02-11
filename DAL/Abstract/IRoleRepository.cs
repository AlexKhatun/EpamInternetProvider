using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IRoleRepository
    {
        ICollection<Role> GetAll();
        Role GetById(int id);
        void Insert(Role role);
        void Update(Role role);
        void Delete(int id);
        void Save();
    }
}
