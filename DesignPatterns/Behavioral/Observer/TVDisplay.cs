namespace DesignPatterns.Behavioral.Observer;

public class TvDisplay : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"TV Display: {message}");
    }
}