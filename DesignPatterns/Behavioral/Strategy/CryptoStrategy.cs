namespace DesignPatterns.Behavioral.Strategy;

public class CryptoStrategy(string wallet) : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"pay {wallet} amount : {amount}");
    }
}