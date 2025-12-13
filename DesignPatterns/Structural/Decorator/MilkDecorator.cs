namespace DesignPatterns.Structural.Decorator;

public class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override double Cost()
    {
        return base.Cost() + 1000;
    }

    public override string Description()
    {
        return base.Description() + ", Milk";
    }
}