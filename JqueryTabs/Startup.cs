using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryTabs.Startup))]
namespace JqueryTabs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
