using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HRSample.Startup))]
namespace HRSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
