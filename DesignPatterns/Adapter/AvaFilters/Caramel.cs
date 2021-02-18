using System;

namespace DesignPatterns.Adapter.AvaFilters
{
    public class Caramel
    {
        public void Init()
        {

        }

        public void Render(Image image)
        {
            Console.WriteLine("Apply Caramel Filters");
        }
    }
}