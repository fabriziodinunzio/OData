using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageLifCycleWebApp.Startup))]
namespace PageLifCycleWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
