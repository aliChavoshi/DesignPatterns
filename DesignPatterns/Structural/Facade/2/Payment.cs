namespace DesignPatterns.Structural.Facade._2;

public class Payment
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"payment is processing... {amount}");
        return true;
    }
}