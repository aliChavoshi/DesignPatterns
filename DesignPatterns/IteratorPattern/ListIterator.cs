namespace DesignPatterns.IteratorPattern
{
    public class ListIterator : IIterator<string>
    {
        private int _index;
        private readonly BrowserHistory _browserHistory;
        public ListIterator(BrowserHistory browserHistory)
        {
            _browserHistory = browserHistory;
        }
        public void Next()
        {
            _index++;
        }
        public string Current()
        {
            return _browserHistory.Get(_index);
        }
        public bool HasNext()
        {
            return (_index < _browserHistory.Count());
        }
    }
}