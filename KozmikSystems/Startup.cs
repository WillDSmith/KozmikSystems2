using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KozmikSystems.Startup))]
namespace KozmikSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
