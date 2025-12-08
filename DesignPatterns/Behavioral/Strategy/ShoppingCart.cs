namespace DesignPatterns.Behavioral.Strategy;

public class ShoppingCart
{
    private readonly List<(string Item, decimal price)> _itemsList = new();
    private IPaymentStrategy? _paymentStrategy;

    public void AddItem(string item, decimal price)
    {
        _itemsList.Add((item, price));
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void Checkout()
    {
        var total = _itemsList.Sum(x => x.price);
        Console.WriteLine($"total price is {total}");

        if (_paymentStrategy != null)
        {
            _paymentStrategy.Pay(total);
        }
        else
        {
            Console.WriteLine("_paymentStrategy is not set.");
        }
    }
}