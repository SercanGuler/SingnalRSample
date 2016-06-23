using Microsoft.Owin;
using Owin;
using SingnalRChat;

[assembly: OwinStartup(typeof(Startup))]
namespace SingnalRChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
