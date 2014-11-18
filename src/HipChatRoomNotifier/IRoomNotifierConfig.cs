using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifier
{
    public interface IRoomNotifierConfig
    {
        string AuthToken { get; }
        string RoomName { get; }
    }
}
