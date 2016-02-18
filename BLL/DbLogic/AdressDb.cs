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
    public class AdressDb : BaseDb
    {
        private readonly IAdressRepository adressDb;

        public AdressDb()
        {
            adressDb = repository.AppKernel.Get<EfAdressRepository>();
        }

        public ICollection<Adress> GetAll()
        {
            return adressDb.GetAll();
        }

        public Adress GetById(int id)
        {
            return adressDb.GetById(id);
        }

        public bool Insert(Adress adress)
        {
            try
            {
                adressDb.Insert(adress);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Adress adress)
        {
            try
            {
                adressDb.Update(adress);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            adressDb.Delete(id);
        }

        public void Save()
        {
            adressDb.Save();
        }
    }
}
