using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PushNotification.Startup))]
namespace PushNotification
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
