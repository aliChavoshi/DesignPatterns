using System.Collections.Generic;

namespace DesignPatterns.CommandPattern.Undoable
{
    public class History
    {
        private readonly Queue<IUndoableCommand> _documents = new();
        public void Push(IUndoableCommand document)
        {
            _documents.Enqueue(document);
        }
        public IUndoableCommand Pop()
        {
            return _documents.Dequeue();
        }
        public int Size()
        {
            return _documents.Count;
        }
    }
}