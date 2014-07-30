using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CambodiaProvider.Web.Startup))]
namespace CambodiaProvider.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
