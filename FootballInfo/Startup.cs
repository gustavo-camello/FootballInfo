using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballInfo.Startup))]
namespace FootballInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
