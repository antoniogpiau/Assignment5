using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment5New.Startup))]
namespace Assignment5New
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
