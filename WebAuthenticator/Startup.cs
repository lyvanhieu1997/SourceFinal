using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAuthenticator.Startup))]
namespace WebAuthenticator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
