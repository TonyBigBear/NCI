using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCI.Startup))]
namespace NCI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
