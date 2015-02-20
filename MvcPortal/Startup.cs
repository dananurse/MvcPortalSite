using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPortal.Startup))]
namespace MvcPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
