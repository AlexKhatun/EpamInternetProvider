using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IPurseRepository
    {
        ICollection<Purse> GetAll();
        Purse GetById(int id);
        void Insert(Purse purse);
        void Update(Purse purse);
        void Delete(int id);
        void Save();
    }
}
