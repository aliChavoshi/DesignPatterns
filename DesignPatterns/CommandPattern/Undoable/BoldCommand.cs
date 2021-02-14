namespace DesignPatterns.CommandPattern.Undoable
{
    public class BoldCommand : IUndoableCommand
    {
        private string _prevContent;
        private readonly HtmlDocument _document;
        private readonly History _history;
        public BoldCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _document.GetContent();
            _document.MakeBold();
            _history.Push(this);
        }
        public void Unexecute()
        {
            _document.SetContent(_prevContent);
        }
    }
}