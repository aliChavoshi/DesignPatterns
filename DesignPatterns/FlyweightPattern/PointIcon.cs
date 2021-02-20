namespace DesignPatterns.FlyweightPattern
{
    public class PointIcon
    {
        public PointType Type { get; }
        public byte[] Icon { get; }

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }
    }
}