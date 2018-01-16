using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lucky7MVC.Startup))]
namespace lucky7MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
