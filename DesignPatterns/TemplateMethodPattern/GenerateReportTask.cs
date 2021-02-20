using System;

namespace DesignPatterns.TemplateMethodPattern
{
    public class GenerateReportTask :Task
    {
        public GenerateReportTask()
        {
        }
        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }
    }
}