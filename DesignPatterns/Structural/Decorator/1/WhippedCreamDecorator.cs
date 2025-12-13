namespace DesignPatterns.Structural.Decorator._1;

public class WhippedCreamDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    public override double Cost()
    {
        return base.Cost() + 2000;
    }

    public override string Description()
    {
        return base.Description() + ", Whipped Cream";
    }
}