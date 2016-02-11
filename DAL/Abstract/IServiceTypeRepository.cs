using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;

namespace DAL.Abstract
{
    public interface IServiceTypeRepository
    {
        ICollection<ServiceType> GetAll();
        ServiceType GetById(int id);
        void Insert(ServiceType serviceType);
        void Update(ServiceType serviceType);
        void Delete(int id);
        void Save();
    }
}
