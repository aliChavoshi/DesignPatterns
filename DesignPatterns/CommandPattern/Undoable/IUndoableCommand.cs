using DesignPatterns.CommandPattern.fx;

namespace DesignPatterns.CommandPattern.Undoable
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}