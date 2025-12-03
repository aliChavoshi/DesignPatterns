namespace DesignPatterns.Structural.Adapter._2;

//Individual service with its own interface
public class PayPalService
{
    public void MakePayment(double amountInDollars)
    {
        Console.WriteLine($"PayPal: ${amountInDollars} is payed");
    }

    public bool CheckAccount()
    {
        Console.WriteLine("your account is valid");
        return true;
    }
}