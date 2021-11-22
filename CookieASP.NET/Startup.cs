using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieASP.NET.Startup))]
namespace CookieASP.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
