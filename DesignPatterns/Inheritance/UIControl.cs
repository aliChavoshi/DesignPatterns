using System;

namespace DesignPatterns.Inheritance
{
    public abstract class UiControl
    {
        public void Enable()
        {
            Console.WriteLine("Enable");
        }
        public void Focus()
        {
            Console.WriteLine("Focus");
        }

        public void SetPosition()
        {
            Console.WriteLine("SetPosition");
        }

        public abstract void Draw();
    }
}