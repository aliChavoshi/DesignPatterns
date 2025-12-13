namespace DesignPatterns.Structural.Decorator._1;

public class SugarDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override double Cost()
    {
        return base.Cost() + 500;
    }

    public override string Description()
    {
        return base.Description() + ", Sugar";
    }
}