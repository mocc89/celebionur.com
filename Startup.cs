using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(celebionur.Startup))]
namespace celebionur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
