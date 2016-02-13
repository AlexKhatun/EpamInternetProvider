﻿using System;
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
    public class PurseDb : BaseDb
    {
        private readonly IPurseRepository purseDb;

        public PurseDb()
        {
            purseDb = repository.AppKernel.Get<EfPurseRepository>();
        }

        public ICollection<Purse> GetAll()
        {
            return purseDb.GetAll();
        }

        public Purse GetById(int id)
        {
            return purseDb.GetById(id);
        }

        public void Insert(Purse purse)
        {
            purseDb.Insert(purse);
        }

        public void Update(Purse purse)
        {
            purseDb.Update(purse);
        }

        public void Delete(int id)
        {
            purseDb.Delete(id);
        }

        public void Save()
        {
            purseDb.Save();
        }
    }
}
