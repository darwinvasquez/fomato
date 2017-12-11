using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(disec.Startup))]
namespace disec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
