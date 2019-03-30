using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipesSystem.Startup))]
namespace RecipesSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
