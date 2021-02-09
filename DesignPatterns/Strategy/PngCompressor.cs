using System;

namespace DesignPatterns.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string filename)
        {
            Console.WriteLine($"png Compressing {filename}");
        }
    }
}