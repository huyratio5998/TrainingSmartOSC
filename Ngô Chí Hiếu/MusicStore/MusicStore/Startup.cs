using Microsoft.Owin;
using Owin;
using MusicStore.App_Start;
using System;

[assembly: OwinStartupAttribute(typeof(MusicStore.Startup))]

namespace MusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}