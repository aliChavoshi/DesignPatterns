using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }
        protected override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.Username == "admin" && request.Password == "1234");

            Console.WriteLine("Authentication : " + isValid);
            return !isValid;
        }
    }
}