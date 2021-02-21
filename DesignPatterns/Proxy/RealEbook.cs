using System;

namespace DesignPatterns.Proxy
{
    public class RealEbook : IEBook
    {
        private readonly string _filename;

        public RealEbook(string filename)
        {
            _filename = filename;
            Load();
        }
        public void Load()
        {
            Console.WriteLine($"Loading the EBook : {_filename}");
        }
        public void Show()
        {
            Console.WriteLine($"Showing The EBook  : {_filename}");
        }
        public string GetFileName()
        {
            return _filename;
        }
    }
}