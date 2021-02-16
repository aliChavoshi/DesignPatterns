using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver obs)
        {
            _observers.Add(obs);
        }
        public void Detach(IObserver obs)
        {
            _observers.Remove(obs);
        }
        public void NotifyObserver()
        {
            foreach (var observer in _observers)
                observer.Update();
        }
    }
}