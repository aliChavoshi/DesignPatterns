using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }
        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressing");
            return false;
        }
    }
}