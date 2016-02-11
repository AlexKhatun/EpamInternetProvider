using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IAdressRepository
    {
        ICollection<Adress> GetAll();
        Adress GetById(int id);
        void Insert(Adress adress);
        void Update(Adress adress);
        void Delete(int id);
        void Save();
    }
}
