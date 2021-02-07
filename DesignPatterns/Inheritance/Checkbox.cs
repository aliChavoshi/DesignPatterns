using System;

namespace DesignPatterns.Inheritance
{
    public class Checkbox : UiControl
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Checkbox");
        }
    }
}