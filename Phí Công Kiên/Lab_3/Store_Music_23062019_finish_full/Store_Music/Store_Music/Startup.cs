using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store_Music.Startup))]
namespace Store_Music
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
