using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuctionHouseMVC.Startup))]
namespace AuctionHouseMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
