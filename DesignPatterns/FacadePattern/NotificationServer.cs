using System;

namespace DesignPatterns.FacadePattern
{
    public class NotificationServer
    {
        //Connect() - > Connection
        //Authentication(appId,key) -> AuthToken
        //Send(authToken , message , target)
        //connection.disconnect()
        public Connection Connection(string ipAddress)
        {
            return new Connection();
        }

        public AuthToken Authentication(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}