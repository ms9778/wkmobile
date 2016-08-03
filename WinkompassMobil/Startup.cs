using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Winkompass_Mobil.Startup))]
namespace Winkompass_Mobil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
