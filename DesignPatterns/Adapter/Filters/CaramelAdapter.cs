using System.Net;
using DesignPatterns.Adapter.AvaFilters;

namespace DesignPatterns.Adapter.Filters
{
    public class CaramelAdapter : Caramel,IFilter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}