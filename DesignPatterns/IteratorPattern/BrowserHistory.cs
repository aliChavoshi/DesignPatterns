using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.IteratorPattern
{
    public class BrowserHistory
    {
        private readonly string[] _urls = new string[10];
        private int _count;
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
        public int Count()
        {
            return _count;
        }
        public string Get(int index)
        {
            return _urls[index];
        }
        public void Push(string url)
        {
            _urls[_count++] = url;
        }
        public string Pop()
        {
            return _urls[--_count];
        }
    }
}