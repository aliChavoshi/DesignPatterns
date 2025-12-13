namespace DesignPatterns.Structural.Decorator._1;

public class CaramelDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override double Cost()
    {
        return base.Cost() + 1500;
    }

    public override string Description()
    {
        return base.Description() + ", Caramel";
    }
}