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

        public void Insert(Service service)
        {
            serviceDb.Insert(service);
        }

        public void Update(Service service)
        {
            serviceDb.Update(service);
        }

        public void Delete(int id)
        {
            serviceDb.Delete(id);
        }

        public void Save()
        {
            serviceDb.Save();
        }
    }
}
