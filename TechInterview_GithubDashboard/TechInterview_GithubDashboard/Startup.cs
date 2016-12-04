using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechInterview_GithubDashboard.Startup))]
namespace TechInterview_GithubDashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
