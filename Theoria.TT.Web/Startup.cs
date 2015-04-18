using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Theoria.TT.Web.Startup))]
namespace Theoria.TT.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
