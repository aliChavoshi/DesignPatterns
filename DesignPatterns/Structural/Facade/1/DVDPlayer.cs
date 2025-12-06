namespace DesignPatterns.Structural.Facade._1;

public class DvdPlayer
{
    public void On()
    {
        Console.WriteLine("DVD Player is On");
    }

    public void Off()
    {
        Console.WriteLine("DVD Player is Off");
    }

    public void Play(string movie)
    {
        Console.WriteLine($"DVD Player is Playing: {movie}");
    }

    public void Stop()
    {
        Console.WriteLine("DVD Player has Stopped");
    }
}