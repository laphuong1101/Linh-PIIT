using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PIITS.Startup))]
namespace PIITS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
