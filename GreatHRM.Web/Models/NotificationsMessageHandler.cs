using WebSocketManager;
using WebSocketManager.Common;

namespace GreatHRM.Web.Models
{
    public class NotificationsMessageHandler : WebSocketHandler
    {
        public NotificationsMessageHandler(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager, new StringMethodInvocationStrategy())
        {
        }
    }
}