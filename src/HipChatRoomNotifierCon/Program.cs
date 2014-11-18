using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HipChatRoomNotifier;

namespace HipChatRoomNotifierCon
{
    class Program
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly int Exit_Successful = 0;
        private static readonly int Exit_Failure = -1;
        private static readonly int Exit_Error = -2;

        static void Main(string[] args)
        {
            Console.Clear();

            _log.Info("Starting...");

            try
            {
                var parser = new CommandLineParser();
                var commandLineArgs = parser.Parse(args);

                var config = RoomNotificationMapper.MapToRoomNotifierConfig(commandLineArgs);
                var notification = RoomNotificationMapper.MapToRoomNotification(commandLineArgs);

                var notifier = new RoomNotifier(config);
                var notifyTask = notifier.Notify(notification);
                Task.WaitAll(notifyTask);

                var notificationResult = notifyTask.Result;

                if ( !notificationResult.Successful )
                { 
                    _log.Warn("Failure: Notification not sent");
                    _log.Warn("  HTTP Status Code: " + notificationResult.StatusCode);
                    _log.Warn("  Reason: " + notificationResult.ReasonPhrase);
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    Environment.Exit(Exit_Failure);
                }
            }
            catch ( Exception ex )
            { 
                _log.Error("Error: Notification not sent");
                _log.Error("  Message: " + ex.Message);
                _log.Debug("Unhanded exception", ex);
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                Environment.Exit(Exit_Error);
            }

            _log.Info("Success: Notification sent");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(Exit_Successful);
        }
    }
}
