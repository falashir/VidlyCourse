using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyCourse.Startup))]
namespace VidlyCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
