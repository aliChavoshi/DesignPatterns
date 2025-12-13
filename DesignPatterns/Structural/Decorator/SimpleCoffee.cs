namespace DesignPatterns.Structural.Decorator;

public class SimpleCoffee : ICoffee
{
    public double Cost()
    {
        return 5000;
    }

    public string Description()
    {
        return "Simple Coffee";
    }
}