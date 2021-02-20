using System;

namespace DesignPatterns.FlyweightPattern
{
    public class Point
    {
        private readonly int _x; // 4byte
        private readonly int _y; // 4byte
        private readonly PointIcon _pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
        }
        public void Draw()
        {
            Console.WriteLine("{0} : {1}", _pointIcon.Type, (_x, _y));
        }
    }
    public enum PointType
    {
        Cafe,
        Hospital
    }
}