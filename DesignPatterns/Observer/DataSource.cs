using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class DataSource : Subject
    {
        private int _value;
        public void SetValue(int value)
        {
            _value = value;
            NotifyObserver();
        }
        public int GetValue()
        {
            return _value;
        }
    }
}