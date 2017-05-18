using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Template.Web.Startup))]
namespace MVC5Template.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
