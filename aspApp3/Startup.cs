using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspApp3.Startup))]
namespace aspApp3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
