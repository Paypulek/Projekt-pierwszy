using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Server.Hubs;

public class ChatHub : Hub
{
    List<string> ListOfMessage = new List<string>();
    public async Task SendMessage(string user, string message)
    {
        ListOfMessage.Add(message);
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public async Task ReciveMessage()
    {
        int number =0;
        foreach (string item in ListOfMessage)
        {
        await Clients.All.SendAsync("AllMessage", number, item);
        number++;
        }
    }
}