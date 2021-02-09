using System;

namespace DesignPatterns.Strategy
{
    public class BlackAndWhite:IFilter
    {
        public void Apply(string filename)
        {
            Console.WriteLine($"Applying B&W {filename}");
        }
    }
}