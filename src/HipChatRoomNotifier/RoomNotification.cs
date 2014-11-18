using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifier
{
    public class RoomNotification
    {
        public MessageColor Color { get; set; }
        public string Message { get; set; }
        public bool Notify { get; set; }
        public MessageFormat Format { get; set; }
    }
}
