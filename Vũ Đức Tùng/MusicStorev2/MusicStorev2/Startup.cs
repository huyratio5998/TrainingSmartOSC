using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStorev2.Startup))]
namespace MusicStorev2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
