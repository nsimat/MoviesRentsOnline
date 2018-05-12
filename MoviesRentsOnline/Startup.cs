using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRentsOnline.Startup))]
namespace MoviesRentsOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
