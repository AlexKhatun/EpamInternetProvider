using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Concrete;
using Ninject;
using Ninject.Modules;

namespace BLL.Binding
{
    public class Repository : NinjectModule
    {
        public IKernel AppKernel;

        public Repository()
        {
            AppKernel = new StandardKernel(this);
        }

        public override void Load()
        {
            this.Bind<IRoleRepository>().To<EfRoleRepository>();
            this.Bind<IUserRepository>().To<EfUserRepository>();
            this.Bind<IAdressRepository>().To<EfAdressRepository>();
            this.Bind<IPurseRepository>().To<EfPurseRepository>();
            this.Bind<IServiceTypeRepository>().To<EfServiseTypeRepository>();
            this.Bind<IServiceRepository>().To<EfServiceRepository>();
            this.Bind<IRateRepository>().To<EfRateRepository>();
            this.Bind<ISubscribeRepository>().To<EfSubscribeRepository>();
        }
    }
}
