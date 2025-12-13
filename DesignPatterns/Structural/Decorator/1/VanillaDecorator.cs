namespace DesignPatterns.Structural.Decorator._1;

public class VanillaDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override double Cost()
    {
        return base.Cost() + 1200;
    }

    public override string Description()
    {
        return base.Description() + ", Vanilla";
    }
}