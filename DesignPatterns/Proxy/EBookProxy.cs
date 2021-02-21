namespace DesignPatterns.Proxy
{
    public class EBookProxy : IEBook
    {
        private readonly string _filename;
        private RealEbook _ebook;

        public EBookProxy(string filename)
        {
            _filename = filename;
        }
        public void Show()
        {
            _ebook ??= new RealEbook(_filename);
            _ebook.Show();
        }

        public string GetFileName()
        {
            return _filename;
        }
    }
}