using System;

namespace DesignPatterns.Strategy
{
    public class HighContrast : IFilter
    {
        public void Apply(string filename)
        {
            Console.WriteLine($"Applying High Contrast {filename}");
        }
    }
}