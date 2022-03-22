using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AKTeam.Startup))]
namespace AKTeam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
