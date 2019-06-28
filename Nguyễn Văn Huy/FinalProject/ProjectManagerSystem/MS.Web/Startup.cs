using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MS.Web.Startup))]
namespace MS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
