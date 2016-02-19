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

        public bool Insert(ServiceType serviceType)
        {
            try
            {
                serviceTypeDb.Insert(serviceType);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(ServiceType serviceType)
        {
            try
            {
                serviceTypeDb.Update(serviceType);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                serviceTypeDb.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            serviceTypeDb.Save();
        }
    }
}
