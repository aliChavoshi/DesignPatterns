using System;

namespace DesignPatterns.Strategy
{
    public class JpegCompressor:ICompressor
    {
        public void Compress(string filename)
        {
            Console.WriteLine($"Jpeg Compressing {filename}");
        }
    }
}