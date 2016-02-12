using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace CrossPlatFormMessenger.Hubs
{
    public class ChatHubs:Hub
    {
       // public void SendMessage(ChatMessage message)
              public void SendMessage(ChatMessage message)
        {
            Clients.All.GetMessage(message);
        }

    }

    public class ChatMessage
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
