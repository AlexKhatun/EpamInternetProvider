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
    public class EfAdressRepository : EfAllRepository, IAdressRepository
    {
        public ICollection<Adress> GetAll()
        {
            return db.Adress.ToList();
        }

        public Adress GetById(int id)
        {
            return db.Adress.First(x => x.AdressId == id);
        }

        public void Insert(Adress adress)
        {
            db.Adress.Add(adress);
            this.Save();
        }

        public void Update(Adress adress)
        {
            var a = db.Adress.Find(adress.AdressId);
            a.City = adress.City;
            a.Street = adress.Street;
            a.Flat = adress.Flat;
            a.PhoneNumber = adress.PhoneNumber;
            a.House = a.House;
            //db.Entry(adress).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Adress.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
