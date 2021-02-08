namespace DesignPatterns.State
{
    public class Canvas
    {
        private readonly Tool _toolType;
        public Canvas(Tool toolType)
        {
            _toolType = toolType;
        }

        public void MouseUp()
        {
            _toolType.MouseUp();
        }

        public void MouseDown()
        {
            _toolType.MouseDown();
        }
    }
}