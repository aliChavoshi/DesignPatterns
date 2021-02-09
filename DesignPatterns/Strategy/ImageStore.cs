using System;

namespace DesignPatterns.Strategy
{
    public class ImageStore
    {
        public void Store(string filename, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(filename);
            filter.Apply(filename);
            Console.WriteLine($"Store {filename} in Db");
        }
    }
}