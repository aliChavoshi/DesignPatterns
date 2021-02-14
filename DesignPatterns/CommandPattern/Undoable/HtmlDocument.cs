using System;
using DesignPatterns.CommandPattern.fx;

namespace DesignPatterns.CommandPattern.Undoable
{
    public class HtmlDocument 
    {
        private string _content;
        public void MakeBold()
        {
            _content = "<br>" + _content + "</b>";
        }
        public void MakeItalic()
        {
            _content = "<i>" + _content + "</i>";
        }
        public string GetContent() => _content;
        public void SetContent(string content)
        {
            _content = content;
        }
    }
}