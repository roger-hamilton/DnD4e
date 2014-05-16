using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnD4e_Web.Startup))]
namespace DnD4e_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
