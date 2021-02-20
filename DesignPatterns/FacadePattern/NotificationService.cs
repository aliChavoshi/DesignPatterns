namespace DesignPatterns.FacadePattern
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connection("ip");
            var authToken = server.Authentication("appId", "key");
            server.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}