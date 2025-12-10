namespace DesignPatterns.Behavioral.Observer;

public class PhoneDisplay : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Phone Display: {message}");
    }
}