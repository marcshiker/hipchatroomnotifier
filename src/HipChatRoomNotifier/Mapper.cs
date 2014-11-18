using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifier
{
    internal static class Mapper
    {
        private static string MapToColor(MessageColor messageColor)
        { 
            if (messageColor == MessageColor.Gray)
                return "gray";
            else if (messageColor == MessageColor.Green)
                return "green";
            else if (messageColor == MessageColor.Purple)
                return "purple";
            else if (messageColor == MessageColor.Random)
                return "random";
            else if (messageColor == MessageColor.Red)
                return "red";
            else if (messageColor == MessageColor.Yellow)
                return "yellow";
            else
                return "yellow";
        }
        private static string MapToMessageFormat(MessageFormat messageFormat)
        { 
            if (messageFormat == MessageFormat.Html)
                return "html";
            else if (messageFormat == MessageFormat.Text)
                return "text";
            else
                return "html";
        }
        
        public static HipChatRoomNotification MapToHipChatRoomNotification(RoomNotification roomNotification)
        { 
            if (roomNotification == null)
                throw new ArgumentNullException("roomNotification");

            var mapped = new HipChatRoomNotification
            {
                color = Mapper.MapToColor(roomNotification.Color),
                message = roomNotification.Message,
                message_format = Mapper.MapToMessageFormat(roomNotification.Format),
                notify = roomNotification.Notify
            };

            return mapped;
        }
    }
}
