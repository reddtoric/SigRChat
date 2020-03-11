using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SigRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(SerializedHubMessage message) =>
            await Clients.All.SendAsync("recieveMessage", message);
    }
}
