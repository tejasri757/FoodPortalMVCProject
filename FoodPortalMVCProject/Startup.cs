using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodPortalMVCProject.Startup))]
namespace FoodPortalMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
