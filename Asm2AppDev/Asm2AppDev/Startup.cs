using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asm2AppDev.Startup))]
namespace Asm2AppDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
