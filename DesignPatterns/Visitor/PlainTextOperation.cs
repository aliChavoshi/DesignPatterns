using System;

namespace DesignPatterns.Visitor
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("PlainText - heading");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("PlainText - anchor");
        }
    }
}