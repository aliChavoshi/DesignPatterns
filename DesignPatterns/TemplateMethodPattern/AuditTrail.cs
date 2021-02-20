using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class AuditTrail
    {
        public void Record(string message)
        {
            Console.WriteLine("Record Task");
        }
    }
}