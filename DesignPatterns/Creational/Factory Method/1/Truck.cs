namespace DesignPatterns.Creational.Factory_Method._1;

public class Truck : ITransport
{
    public void Deliver(string package)
    {
        Console.WriteLine($"Delivering {package} by truck.");
    }
}