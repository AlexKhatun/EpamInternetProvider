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
    public class RateDb : BaseDb
    {
        private readonly IRateRepository rateDb;

        public RateDb()
        {
            rateDb = repository.AppKernel.Get<EfRateRepository>();
        }

        public ICollection<Rate> GetAll()
        {
            return rateDb.GetAll();
        }

        public Rate GetById(int id)
        {
            return rateDb.GetById(id);
        }

        public void Insert(Rate rate)
        {
            rateDb.Insert(rate);
        }

        public void Update(Rate rate)
        {
            rateDb.Update(rate);
        }

        public void Delete(int id)
        {
            rateDb.Delete(id);
        }

        public void Save()
        {
            rateDb.Save();
        }
    }
}
