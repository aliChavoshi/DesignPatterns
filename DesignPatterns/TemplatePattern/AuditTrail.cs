using System;

namespace DesignPatterns.TemplatePattern
{
    public class AuditTrail
    {
        public void Record(string message)
        {
            Console.WriteLine("Record Task");
        }
    }
}