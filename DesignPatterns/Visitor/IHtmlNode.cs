namespace DesignPatterns.Visitor
{
    //dependency
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}