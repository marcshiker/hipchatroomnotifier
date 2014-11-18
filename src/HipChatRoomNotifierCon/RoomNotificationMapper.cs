using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HipChatRoomNotifier;

namespace HipChatRoomNotifierCon
{
    internal static class RoomNotificationMapper
    {
        private static MessageColor MapToMessageColor(string color)
        {
            switch ( color.ToLower() )
            { 
                case "yellow":
                    return MessageColor.Yellow;
                case "green":
                    return MessageColor.Green;
                case "red":
                    return MessageColor.Red;
                case "purple":
                    return MessageColor.Purple;
                case "gray":
                    return MessageColor.Gray;
                case "random":
                    return MessageColor.Random;
                default:
                    return MessageColor.Yellow; // default
            }
        }
        private static MessageFormat MapToMessageFormat(string messageFormat)
        {
            switch ( messageFormat.ToLower() )
            { 
                case "html":
                    return MessageFormat.Html;
                case "text":
                    return MessageFormat.Text;
                default:
                    return MessageFormat.Html; // default
            }
        }
        private static bool MapToNotify(string notifyString)
        { 
            bool notify = false;
            Boolean.TryParse(notifyString, out notify);
            return notify;

        }

        public static RoomNotification MapToRoomNotification(CommandLineArgs commandLineArgs)
        { 
            if (commandLineArgs == null)
                throw new ArgumentNullException("commandLineArgs");

            var mapped = new RoomNotification
            {
                Color = RoomNotificationMapper.MapToMessageColor(commandLineArgs.Color),
                Format = RoomNotificationMapper.MapToMessageFormat(commandLineArgs.Format),
                Message = commandLineArgs.Message,
                Notify = RoomNotificationMapper.MapToNotify(commandLineArgs.Notify),
            };

            return mapped;
        }
        public static IRoomNotifierConfig MapToRoomNotifierConfig(CommandLineArgs commandLineArgs)
        { 
            if (commandLineArgs == null)
                throw new ArgumentNullException("commandLineArgs");

            var mapped = new RoomNotifierConfig(commandLineArgs.AuthToken, commandLineArgs.RoomName);
            return mapped;
        }
    }
}
