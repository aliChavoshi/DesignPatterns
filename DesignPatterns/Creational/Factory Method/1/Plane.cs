namespace DesignPatterns.Creational.Factory_Method._1;

public class Plane : ITransport
{
    public void Deliver(string package)
    {
        Console.WriteLine($"Delivering {package} by plane.");
    }
}