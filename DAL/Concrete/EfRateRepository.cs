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
    class EfRateRepository : EfAllRepository, IRateRepository
    {
        public ICollection<Rate> GetAll()
        {
            return db.Rate.ToList();
        }

        public Rate GetById(int id)
        {
            return db.Rate.First(x => x.RateId == id);
        }

        public void Insert(Rate rate)
        {
            db.Rate.Add(rate);
            this.Save();
        }

        public void Update(Rate rate)
        {
            db.Entry(rate).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Rate.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
