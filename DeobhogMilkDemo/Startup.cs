using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeobhogMilkDemo.Startup))]
namespace DeobhogMilkDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
