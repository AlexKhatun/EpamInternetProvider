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
    public class EfServiceRepository : EfAllRepository, IServiceRepository
    {
        public ICollection<Service> GetAll()
        {
            return db.Service.ToList();
        }

        public Service GetById(int id)
        {
            return db.Service.First(x => x.ServiceId == id);
        }

        public void Insert(Service service)
        {
            db.Service.Add(service);
            this.Save();
        }

        public void Update(Service service)
        {
            db.Entry(service).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Service.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
