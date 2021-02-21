using System;

namespace DesignPatterns.Proxy
{
    public class LoggingEbookProxy : IEBook
    {
        private readonly string _filename;
        private RealEbook _ebook;
        public LoggingEbookProxy(string filename)
        {
            _filename = filename;
        }
        public void Show()
        {
            _ebook ??= new RealEbook(_filename);
            Console.WriteLine($"logging : {_filename}");
            _ebook.Show();
        }

        public string GetFileName()
        {
            return _filename;
        }
    }
}