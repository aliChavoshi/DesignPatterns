using DesignPatterns.DependencyInjection;
using DesignPatterns.Inheritance;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing(new Checkbox());
            Drawing(new TextBox());
        }

        static void Drawing(UiControl control)
        {
            control.Draw();
        }

        static ITaxCalculator Calculator()
        {
            return new CalculateTax2019();
        }
    }
}
