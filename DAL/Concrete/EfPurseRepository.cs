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
    public class EfPurseRepository : EfAllRepository, IPurseRepository
    {
        public ICollection<Purse> GetAll()
        {
            return db.Purse.ToList();
        }

        public Purse GetById(int id)
        {
            return db.Purse.First(x => x.PurseId == id);
        }

        public void Insert(Purse purse)
        {
            db.Purse.Add(purse);
            this.Save();
        }

        public void Update(Purse purse)
        {
            db.Entry(purse).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Purse.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
