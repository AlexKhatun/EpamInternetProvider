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
    public class SubscribeDb : BaseDb
    {
        private readonly ISubscribeRepository subscribeDb;

        public SubscribeDb()
        {
            subscribeDb = repository.AppKernel.Get<EfSubscribeRepository>();
        }

        public ICollection<Subscribe> GetAll()
        {
            return subscribeDb.GetAll();
        }

        public Subscribe GetById(int id)
        {
            return subscribeDb.GetById(id);
        }

        public bool Insert(Subscribe subscribe)
        {
            try
            {
                subscribeDb.Insert(subscribe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Subscribe subscribe)
        {
            try
            {
                subscribeDb.Update(subscribe);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            subscribeDb.Delete(id);
        }

        public void Save()
        {
            subscribeDb.Save();
        }
    }
}
