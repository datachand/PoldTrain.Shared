using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoldTrain.Shared.Dashboard.Startup))]
namespace PoldTrain.Shared.Dashboard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
