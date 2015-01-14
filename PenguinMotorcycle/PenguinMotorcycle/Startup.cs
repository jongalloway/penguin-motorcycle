using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PenguinMotorcycle.Startup))]
namespace PenguinMotorcycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
