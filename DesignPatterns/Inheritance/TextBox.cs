using System;

namespace DesignPatterns.Inheritance
{
    public class TextBox : UiControl
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Text Box");
        }
    }
}