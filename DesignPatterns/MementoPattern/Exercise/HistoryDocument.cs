using System.Collections.Generic;

namespace DesignPatterns.MementoPattern.Exercise
{
    public class HistoryDocument
    {
        private readonly Stack<DocumentState> _states = new Stack<DocumentState>();

        public void Push(DocumentState state)
        {
            _states.Push(state);
        }

        public DocumentState Pop()
        {
            return _states.Pop();
        }
    }
}