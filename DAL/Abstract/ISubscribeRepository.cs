using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface ISubscribeRepository
    {
        ICollection<Subscribe> GetAll();
        Subscribe GetById(int id);
        void Insert(Subscribe subscribe);
        void Update(Subscribe subscribe);
        void Delete(int id);
        void Save();
    }
}
