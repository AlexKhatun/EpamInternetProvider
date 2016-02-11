using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IRateRepository
    {
        ICollection<Rate> GetAll();
        Rate GetById(int id);
        void Insert(Rate rate);
        void Update(Rate rate);
        void Delete(int id);
        void Save();
    }
}
