using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(giuaki.Startup))]
namespace giuaki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
