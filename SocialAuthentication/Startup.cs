using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialAuthentication.Startup))]
namespace SocialAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
