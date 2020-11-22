using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TelerikGrid.Startup))]
namespace TelerikGrid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
