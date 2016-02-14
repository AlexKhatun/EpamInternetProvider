using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EpamInternetProvider.Startup))]
namespace EpamInternetProvider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
