using System.Collections.Generic;

namespace DesignPatterns.Proxy
{
    public class Library
    {
        private readonly Dictionary<string, IEBook> _eBooks = new();

        public void Add(IEBook eBook)
        {
            _eBooks.Add(eBook.GetFileName(), eBook);
        }

        public void OpenEBook(string filename)
        {
            _eBooks[filename].Show();
        }
    }
}