using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment5.Startup))]
namespace Assignment5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
