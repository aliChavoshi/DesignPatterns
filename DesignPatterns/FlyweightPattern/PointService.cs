using System.Collections.Generic;

namespace DesignPatterns.FlyweightPattern
{
    public class PointService
    {
        private readonly PointIconFactory _pointIconFactory;
        public PointService(PointIconFactory pointIconFactory)
        {
            _pointIconFactory = pointIconFactory;
        }
        public List<Point> GetPoints()
        {
            var points = new List<Point>();

            var point = new Point(1, 2, _pointIconFactory.GetPointIcon(PointType.Cafe));

            points.Add(point);
            return points;
        }
    }
}