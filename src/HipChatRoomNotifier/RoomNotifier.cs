using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HipChatRoomNotifier
{
    public class RoomNotifier
    {
        private readonly Uri _hipChatBaseUri = new Uri("https://api.hipchat.com");
        private readonly IRoomNotifierConfig _config;

        public RoomNotifier(IRoomNotifierConfig config)
        { 
            if (config == null)
                throw new ArgumentNullException("config");

            _config = config;
        }

        public async Task<RoomNotificationResult> Notify(RoomNotification roomNotification)
        { 
            if (roomNotification == null)
                throw new ArgumentNullException("roomNotification");

            var hipChatRoomNotification = Mapper.MapToHipChatRoomNotification(roomNotification);

            using ( var client = new HttpClient() )
            { 
                client.BaseAddress = _hipChatBaseUri;
                string uri = String.Format("v2/room/{0}/notification?auth_token={1}", _config.RoomName, _config.AuthToken);
                var response = await client.PostAsJsonAsync(uri, hipChatRoomNotification);
                
                var result = new RoomNotificationResult()
                {
                    ReasonPhrase = response.ReasonPhrase,
                    StatusCode = response.StatusCode,
                    Successful = response.IsSuccessStatusCode,
                };

                return result;
            }
        }
    }
}
