using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5_04_1.Startup))]
namespace MVC5_04_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
