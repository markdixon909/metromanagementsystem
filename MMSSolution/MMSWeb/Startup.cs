using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MMSWeb.Startup))]
namespace MMSWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
