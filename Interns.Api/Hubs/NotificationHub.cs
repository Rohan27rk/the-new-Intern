using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Interns.Api.Hubs
{
    public class NotificationHub : Hub
    {
        // Called when a client connects
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "System", "Connected to Notification Hub");
            await base.OnConnectedAsync();
        }

        // Called when a client disconnects
        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await base.OnDisconnectedAsync(exception);
        }

        // Custom method for sending notifications
        public async Task SendNotification(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
