using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Another_Website.Startup))]
namespace Another_Website
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
