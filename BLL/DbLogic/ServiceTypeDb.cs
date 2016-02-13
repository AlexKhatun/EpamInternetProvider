using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;
using DAL.Abstract;
using DAL.Concrete;
using Ninject;

namespace BLL.DbLogic
{
    public class ServiceTypeDb : BaseDb
    {
        private readonly IServiceTypeRepository serviceTypeDb;

        public ServiceTypeDb()
        {
            serviceTypeDb = repository.AppKernel.Get<EfServiseTypeRepository>();
        }

        public ICollection<ServiceType> GetAll()
        {
            return serviceTypeDb.GetAll();
        }

        public ServiceType GetById(int id)
        {
            return serviceTypeDb.GetById(id);
        }

        public void Insert(ServiceType serviceType)
        {
            serviceTypeDb.Insert(serviceType);
        }

        public void Update(ServiceType serviceType)
        {
            serviceTypeDb.Update(serviceType);
        }

        public void Delete(int id)
        {
            serviceTypeDb.Delete(id);
        }

        public void Save()
        {
            serviceTypeDb.Save();
        }
    }
}
