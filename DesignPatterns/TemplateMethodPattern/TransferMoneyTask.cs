using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class TransferMoneyTask:Task
    {
        public TransferMoneyTask()
        {
        }
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}