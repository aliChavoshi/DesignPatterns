namespace DesignPatterns.Structural.Facade._2;

public class OrderFacade
{
    private readonly Inventory _inventory;
    private readonly Payment _payment;
    private readonly Shipping _shipping;
    private readonly Notification _notification;

    public OrderFacade()
    {
        _inventory = new Inventory();
        _payment = new Payment();
        _shipping = new Shipping();
        _notification = new Notification();
    }

    public bool PlaceOrder(string productId, decimal amount,
        string address, string email)
    {
        Console.WriteLine(" order process started...");

        if (!_inventory.CheckStock(productId))
        {
            Console.WriteLine("❌ Product is out of stock");
            return false;
        }

        if (!_payment.ProcessPayment(amount))
        {
            Console.WriteLine("❌ Payment failed");
            return false;
        }

        _shipping.ArrangeShipping(address);
        _notification.SendConfirmation(email);

        Console.WriteLine("payment is successful");
        return true;
    }
}