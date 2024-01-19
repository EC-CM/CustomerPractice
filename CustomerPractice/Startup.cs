using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerPractice.Startup))]
namespace CustomerPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
