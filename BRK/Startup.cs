using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BRK.Startup))]
namespace BRK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
