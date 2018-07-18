using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(siddu07182018.Startup))]
namespace siddu07182018
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
