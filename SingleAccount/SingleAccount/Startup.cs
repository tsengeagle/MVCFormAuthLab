using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingleAccount.Startup))]
namespace SingleAccount
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
