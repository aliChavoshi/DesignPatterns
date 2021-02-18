using System;
using System.Threading.Channels;

namespace DesignPatterns.Adapter.Filters
{
    public class VividFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Apply Vivid Filters");
        }
    }
}