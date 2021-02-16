namespace DesignPatterns.Visitor
{
    public interface IOperation
    {
        //Overloading
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}