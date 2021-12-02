using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APIGoogleAuthentication.Startup))]
namespace APIGoogleAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
