using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookieCollection.Startup))]
namespace CookieCollection
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
