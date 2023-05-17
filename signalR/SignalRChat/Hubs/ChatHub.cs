using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public static int liczbaWiadomosci =0;
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, liczbaWiadomosci);
            liczbaWiadomosci++;
        }

        public async Task DeleteMessage()
        {
            await Clients.All.SendAsync("DeleteTable");
        }
    }
}