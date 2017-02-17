using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MUE.Startup))]
namespace MUE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
