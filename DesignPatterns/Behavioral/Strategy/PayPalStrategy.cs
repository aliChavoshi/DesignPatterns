namespace DesignPatterns.Behavioral.Strategy;

public class PayPalStrategy(string email) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"pay {email} amount : {amount}");
    }
}