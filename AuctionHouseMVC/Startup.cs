using Microsoft.Owin;
using Ninject;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionHouseMVC.Startup))]
namespace AuctionHouseMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            IKernel ninjectKernel = new StandardKernel();
            
            ConfigureAuth(app);
        }
    }
}
