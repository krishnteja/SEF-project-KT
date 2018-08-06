using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaDeliveryWebApplication.Startup))]
namespace PizzaDeliveryWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
