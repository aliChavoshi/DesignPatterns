using System.Collections.Generic;

namespace DesignPatterns.MementoPattern
{
    public class History
    {
        private readonly Stack<EditorState> _states = new Stack<EditorState>();

        public void Push(EditorState state)
        {
            _states.Push(state);
        }

        public EditorState Pop()
        {
            return _states.Pop();
        }
    }
}