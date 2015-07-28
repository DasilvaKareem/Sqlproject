using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlPRoject.Startup))]
namespace SqlPRoject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
