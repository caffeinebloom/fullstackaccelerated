using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FSA.Startup))]
namespace FSA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
