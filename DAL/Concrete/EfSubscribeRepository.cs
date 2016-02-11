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
    class EfSubscribeRepository : EfAllRepository, ISubscribeRepository
    {
        public ICollection<Subscribe> GetAll()
        {
            return db.Subscribe.ToList();
        }

        public Subscribe GetById(int id)
        {
            return db.Subscribe.First(x => x.SubscribeId == id);
        }

        public void Insert(Subscribe subscribe)
        {
            db.Subscribe.Add(subscribe);
            this.Save();
        }

        public void Update(Subscribe subscribe)
        {
            db.Entry(subscribe).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Subscribe.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
