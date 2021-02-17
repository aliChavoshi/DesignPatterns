using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument : IHtmlNode
    {
        private readonly List<IHtmlNode> _htmlNodes = new();
        public void Add(IHtmlNode node)
        {
            _htmlNodes.Add(node);
        }
        public void Execute(IOperation operation)
        {
            foreach (var htmlNode in _htmlNodes)
                htmlNode.Execute(operation: operation);
        }
    }
}