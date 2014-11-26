using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cimsco.Startup))]
namespace Cimsco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
