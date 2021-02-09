using System;

namespace DesignPatterns.TemplatePattern
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