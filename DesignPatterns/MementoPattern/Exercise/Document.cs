namespace DesignPatterns.MementoPattern.Exercise
{
    public class Document
    {
        private string _content;
        private string _fontName;
        private int _fontSize;

        public DocumentState CreateState()
        {
            return new DocumentState(_content, _fontName, _fontSize);
        }
        public void Restore(DocumentState state)
        {
            _content = state.GetContent();
            _fontName = state.GetFontName();
            _fontSize = state.GetFontSize();
        }
        public string GetContent()
        {
            return _content;
        }
        public string GetFontName()
        {
            return _fontName;
        }
        public int GetSizeFont()
        {
            return _fontSize;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public void SetFontName(string font)
        {
            _fontName = font;
        }

        public void SetFontSize(int size)
        {
            _fontSize = size;
        }
    }
}