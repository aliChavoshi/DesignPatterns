﻿using System;

namespace DesignPatterns.TemplatePattern
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