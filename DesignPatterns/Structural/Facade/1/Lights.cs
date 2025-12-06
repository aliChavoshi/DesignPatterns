namespace DesignPatterns.Structural.Facade._1;

public class Lights
{
    public void Dim(int level)
    {
        Console.WriteLine($"Dimmed to {level}%");
    }

    public void On()
    {
        Console.WriteLine("Lights are On");
    }
}