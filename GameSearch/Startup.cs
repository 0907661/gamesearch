using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameSearch.Startup))]
namespace GameSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
