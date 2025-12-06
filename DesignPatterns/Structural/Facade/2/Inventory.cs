namespace DesignPatterns.Structural.Facade._2;

public class Inventory
{
    public bool CheckStock(string productId)
    {
        Console.WriteLine($" progressing of {productId}");
        return true;
    }
}