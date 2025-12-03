namespace DesignPatterns.Structural.Adapter._2;

public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalService _payPalService = new();

    public void ProcessPayment(decimal amount, string currency)
    {
        // تبدیل به دلار (اگر لازم باشد)
        double amountInDollars = currency == "USD"
            ? (double)amount
            : (double)amount / 118_000; // تبدیل تومان به دلار

        _payPalService.MakePayment(amountInDollars);
    }

    public bool ValidatePayment()
    {
        return _payPalService.CheckAccount();
    }
}