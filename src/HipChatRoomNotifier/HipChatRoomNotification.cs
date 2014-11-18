using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifier
{
    internal class HipChatRoomNotification
    {
        public string color { get; set; }
        public string message { get; set; }
        public bool notify { get; set; }
        public string message_format { get; set; }
    }
}
