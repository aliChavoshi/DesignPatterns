namespace DesignPatterns.CommandPattern.Undoable
{
    public class ItalicCommand : IUndoableCommand
    {
        private string _prevContent;
        private readonly HtmlDocument _document;
        private readonly History _history;
        public ItalicCommand(HtmlDocument document, History history)
        {
            _document = document;
            _history = history;
        }
        public void Execute()
        {
            _prevContent = _document.GetContent();
            _document.MakeItalic();
            _history.Push(this);
        }
        public void Unexecute()
        {
            _document.SetContent(_prevContent);
        }
    }
}