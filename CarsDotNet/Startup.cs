using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsDotNet.Startup))]
namespace CarsDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
