using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(schmitMVCproject.Startup))]
namespace schmitMVCproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
