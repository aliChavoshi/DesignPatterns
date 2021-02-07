using System;

namespace DesignPatterns.Abstraction
{
    public class MailService
    {
        public void SendEmail()
        {
            Connect();
            Authentication();
            //Send Mail
            Disconnect();
        }
        private void Connect()
        {
            Console.WriteLine("Connect");
        }
        private void Disconnect()
        {
            Console.WriteLine("Disconnect");
        }
        private void Authentication()
        {
            Console.WriteLine("Authentication");
        }
    }
}