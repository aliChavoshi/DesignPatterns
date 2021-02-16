using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }
        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging");
            return false;
        }
    }
}