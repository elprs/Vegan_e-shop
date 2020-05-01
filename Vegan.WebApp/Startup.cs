using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vegan.WebApp.Startup))]
namespace Vegan.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
