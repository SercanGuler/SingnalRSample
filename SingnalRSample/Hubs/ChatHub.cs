using Microsoft.AspNet.SignalR;

namespace SingnalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }


        public void Send(string name,string message)
        {
            Clients.All.sendMessage(name,message);
        }
    }
}