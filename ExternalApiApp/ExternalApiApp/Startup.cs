using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExternalApiApp.Startup))]
namespace ExternalApiApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
