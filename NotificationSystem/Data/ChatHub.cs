using Microsoft.AspNetCore.SignalR;

namespace NotificationSystem.Data
{

    public class ChatHub :Hub
    {


        public async Task SendMessage(string sender, string receiver, string msgTitle, string msgBody) 
        {
            await Clients.All.SendAsync("ReceiveMessage", sender, receiver, msgTitle, msgBody);
        }
    }
}
