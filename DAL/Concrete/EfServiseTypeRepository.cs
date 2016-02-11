using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL.Models;
using DAL.Abstract;

namespace DAL.Concrete
{
    public class EfServiseTypeRepository : EfAllRepository, IServiceTypeRepository
    {
        public ICollection<ServiceType> GetAll()
        {
            return db.ServiceType.ToList();
        }

        public ServiceType GetById(int id)
        {
            return db.ServiceType.First(x => x.ServiceTypeId == id);
        }

        public void Insert(ServiceType serviceType)
        {
            db.ServiceType.Add(serviceType);
            this.Save();
        }

        public void Update(ServiceType serviceType)
        {
            db.Entry(serviceType).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.ServiceType.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
