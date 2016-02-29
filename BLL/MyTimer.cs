using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using BLL.DbLogic;

namespace BLL
{
    public class MyTimer : IHttpModule
    {
        private static Timer timer;
        private AllDb db;
        public void Init(HttpApplication context)
        {
            timer = new Timer(new TimerCallback(Withdraw), null, 0, 30000);
            db = new AllDb();
        }

        private void Withdraw(object obj)
        {
            if (DateTime.Now.Hour == 1 && DateTime.Now.Minute == 30)
            {
                foreach (var user in db.UserDb.GetAll())
                {
                    // Тут должна быть транзакция
                    var myUser = user;
                    foreach (var sub in db.SubscribeDb.GetAll().Where(x => x.UserId == myUser.UserId))
                    {
                        user.Purses.First().Money -= sub.Rate.Price;
                    }
                    db.UserDb.Update(user);
                }
            }
        }

        public void Dispose()
        { }
    }
}
