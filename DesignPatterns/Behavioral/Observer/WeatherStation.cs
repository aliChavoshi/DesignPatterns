namespace DesignPatterns.Behavioral.Observer;

public class WeatherStation
{
    private readonly List<IObserver> _observers = [];

    private float _temperature;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
        Console.WriteLine("Observer is attached");
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Observer is detached");
    }

    public void SetTemperature(float temperature)
    {
        Console.WriteLine($"\nWeather Station: New temperature measurement: {temperature}°C");
        _temperature = temperature;
        Notify();
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update($"Current temperature: {_temperature}°C");
        }
    }
}