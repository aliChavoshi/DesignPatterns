namespace DesignPatterns.Structural.Decorator._1;

public abstract class CoffeeDecorator(ICoffee coffee) : ICoffee
{
    public virtual double Cost()
    {
        return coffee.Cost();
    }

    public virtual string Description()
    {
        return coffee.Description();
    }
}