using System.Collections.Generic;

namespace DesignPatterns.Mediator
{
    //Colleague
    //Subject In Observer Pattern
    public abstract class UiControl
    {
        private readonly List<IEventHandler> _eventHandlers = new();
        public void AddEventHandler(IEventHandler eventHandler)
        {
            _eventHandlers.Add(eventHandler);
        }
        protected void NotifyObservers()
        {
            foreach (var eventHandler in _eventHandlers)
                eventHandler.Handle();
        }
    }
}