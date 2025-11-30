namespace DesignPatterns.Factory_Method._1;

public class Ship : ITransport
{
    public void Deliver(string package)
    {
        Console.WriteLine($"Delivering {package} by ship.");
    }
}