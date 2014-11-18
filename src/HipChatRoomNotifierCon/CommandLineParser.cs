using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HipChatRoomNotifierCon
{
    internal class CommandLineParser
    {
        public CommandLineArgs Parse(string[] args)
        { 
            if (args == null)
                throw new ArgumentNullException("args");

            if (args.Length != 6)
                throw new ArgumentOutOfRangeException("args must be contain 6 elements.");

            var commandLineArgs = new CommandLineArgs
            {
                AuthToken = args[0],
                RoomName = args[1],
                Color = args[2],
                Format = args[3],
                Notify = args[4],
                Message = args[5],
            };

            return commandLineArgs;
        }
    }
}
