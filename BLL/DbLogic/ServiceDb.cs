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
    public class ServiceDb : BaseDb
    {
        private readonly IServiceRepository serviceDb;

        public ServiceDb()
        {
            serviceDb = repository.AppKernel.Get<EfServiceRepository>();
        }

        public ICollection<Service> GetAll()
        {
            return serviceDb.GetAll();
        }

        public Service GetById(int id)
        {
            return serviceDb.GetById(id);
        }

        public bool Insert(Service service)
        {
            try
            {
                serviceDb.Insert(service);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Service service)
        {
            try
            {
                serviceDb.Update(service);
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
                serviceDb.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            serviceDb.Save();
        }
    }
}
