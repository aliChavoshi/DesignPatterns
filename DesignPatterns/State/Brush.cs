using System;

namespace DesignPatterns.State
{
    public class Brush : Tool
    {
        public override void MouseUp()
        {
            Console.WriteLine("Brush MouseUp");
        }

        public override void MouseDown()
        {
            Console.WriteLine("Brush MouseDown");
        }
    }
}