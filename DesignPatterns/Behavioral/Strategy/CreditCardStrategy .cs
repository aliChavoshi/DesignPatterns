namespace DesignPatterns.Behavioral.Strategy;

public class CreditCardStrategy(string cardNumber) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"pay {cardNumber} amount : {amount}");
    }
}