namespace DesignPatterns.Behavioral.Observer;

public class TVDisplay : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"TV Display: {message}");
    }
}