using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifierCon
{
    internal class CommandLineArgs
    {
        public string AuthToken { get; set; }
        public string RoomName { get; set; }
        public string Color { get; set; }
        public string Message { get; set; }
        public string Notify { get; set; }
        public string Format { get; set; }
    }
}
