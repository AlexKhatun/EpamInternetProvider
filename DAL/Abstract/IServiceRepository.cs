using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IServiceRepository
    {
        ICollection<Service> GetAll();
        Service GetById(int id);
        void Insert(Service service);
        void Update(Service service);
        void Delete(int id);
        void Save();
    }
}
