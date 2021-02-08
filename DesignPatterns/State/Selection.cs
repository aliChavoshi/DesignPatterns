using System;

namespace DesignPatterns.State
{
    public class Selection : Tool
    {
        public override void MouseUp()
        {
            Console.WriteLine("Selection MouseUp");
        }

        public override void MouseDown()
        {
            Console.WriteLine("Selection MouseDown");
        }
    }
}