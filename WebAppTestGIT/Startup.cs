using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTestGIT.Startup))]
namespace WebAppTestGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
