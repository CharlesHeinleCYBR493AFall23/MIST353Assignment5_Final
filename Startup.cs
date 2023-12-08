using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CharlesHeinle_Assignment4.Startup))]
namespace CharlesHeinle_Assignment4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
