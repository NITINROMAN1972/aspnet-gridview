using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GridViewBind.Startup))]
namespace GridViewBind
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
