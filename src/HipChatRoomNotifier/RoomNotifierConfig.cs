using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifier
{
    public class RoomNotifierConfig : IRoomNotifierConfig
    {
        public RoomNotifierConfig(string authToken, string roomName)
        { 
            if (String.IsNullOrEmpty(authToken))
                throw new ArgumentNullException("authToken");

            if (String.IsNullOrEmpty(roomName))
                throw new ArgumentNullException("roomName");

            this.AuthToken = authToken;
            this.RoomName = roomName;
        }

        public string AuthToken { get; set; }
        public string RoomName { get; set; }
    }
}
