using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(ProductsApi.Startup1))]

namespace ProductsApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR(new HubConfiguration()
            {
                EnableDetailedErrors = true
            });
        }
    }
}
