namespace DesignPatterns.Structural.Adapter._2;

public class InternalPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Internal Payment: {amount} {currency}");
    }

    public bool ValidatePayment() => true;
}