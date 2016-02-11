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
    public class EfRoleRepository : EfAllRepository, IRoleRepository
    {
        public ICollection<Role> GetAll()
        {
            return db.Role.ToList();
        }

        public Role GetById(int id)
        {
            return db.Role.First(x => x.RoleId == id);
        }

        public void Insert(Role role)
        {
            db.Role.Add(role);
            this.Save();
        }

        public void Update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            this.Save();
        }

        public void Delete(int id)
        {
            db.Role.Remove(this.GetById(id));
            this.Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
