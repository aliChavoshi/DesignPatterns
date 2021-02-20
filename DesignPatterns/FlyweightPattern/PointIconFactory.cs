using System.Collections.Generic;

namespace DesignPatterns.FlyweightPattern
{
    public class PointIconFactory
    {
        private readonly Dictionary<PointType, PointIcon> _icons = new();
        public PointIcon GetPointIcon(PointType type)
        {
            if (_icons.ContainsKey(type)) return _icons[type];

            var pointIcon = new PointIcon(type, null);
            _icons.Add(type, pointIcon);
            return _icons[type];
        }
    }
}