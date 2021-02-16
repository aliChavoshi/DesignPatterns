using System;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("highlight-heading");
        }
        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("highlight-Anchor");
        }
    }
}