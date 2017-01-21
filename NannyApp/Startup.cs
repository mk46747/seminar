using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NannyApp.Startup))]
namespace NannyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
