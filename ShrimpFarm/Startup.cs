using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShrimpFarm.Startup))]
namespace ShrimpFarm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
