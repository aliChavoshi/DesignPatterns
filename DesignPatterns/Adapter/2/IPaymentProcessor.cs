namespace DesignPatterns.Adapter._2;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount, string currency);

    bool ValidatePayment();
}