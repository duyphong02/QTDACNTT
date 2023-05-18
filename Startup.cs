using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLBXE.Startup))]
namespace QLBXE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
