using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThePaySourceClient.Startup))]
namespace ThePaySourceClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
