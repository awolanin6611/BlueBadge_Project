using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HiringFair.Startup))]
namespace HiringFair
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
