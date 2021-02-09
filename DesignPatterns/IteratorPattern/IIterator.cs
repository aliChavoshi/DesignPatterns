namespace DesignPatterns.IteratorPattern
{
    public interface IIterator<out T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}