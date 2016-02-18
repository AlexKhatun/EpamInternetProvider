using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Binding;
using BOL.Models;
using DAL.Abstract;
using DAL.Concrete;
using Ninject;

namespace BLL.DbLogic
{
    public class RoleDb : BaseDb
    {
        private readonly IRoleRepository roleDb;

        public RoleDb()
        {
            roleDb = repository.AppKernel.Get<EfRoleRepository>();
        }

        public ICollection<Role> GetAll()
        {
            return roleDb.GetAll();
        }

        public Role GetById(int id)
        {
            return roleDb.GetById(id);
        }

        public bool Insert(Role role)
        {
            try
            {
                roleDb.Insert(role);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Role role)
        {
            try
            {
                roleDb.Update(role);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            roleDb.Delete(id);
        }

        public void Save()
        {
            roleDb.Save();
        }
    }
}
