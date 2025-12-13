namespace DesignPatterns.Structural.Decorator._1;

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