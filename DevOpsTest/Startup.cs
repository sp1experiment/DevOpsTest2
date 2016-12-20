using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsTest.Startup))]
namespace DevOpsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
