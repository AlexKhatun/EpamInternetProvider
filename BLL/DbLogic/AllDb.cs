using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DbLogic
{
    public class AllDb
    {
        public RoleDb RoleDb;
        public UserDb UserDb;
        public AdressDb AdressDb;
        public PurseDb PurseDb;
        public ServiceTypeDb ServiceTypeDb;
        public ServiceDb ServiceDb;
        public RateDb RateDb;
        public SubscribeDb SubscribeDb;

        public AllDb()
        {
            this.RoleDb = new RoleDb();
            this.UserDb = new UserDb();
            this.AdressDb = new AdressDb();
            this.PurseDb = new PurseDb();
            this.ServiceTypeDb = new ServiceTypeDb();
            this.ServiceDb = new ServiceDb();
            this.RateDb = new RateDb();
            this.SubscribeDb = new SubscribeDb();
        }
    }
}
