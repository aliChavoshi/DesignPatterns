using System;

namespace DesignPatterns.State
{
    public class Eraser : Tool
    {
        public override void MouseUp()
        {
            Console.WriteLine("Eraser Icon");
        }

        public override void MouseDown()
        {
            Console.WriteLine("Eraser something");
        }
    }
}