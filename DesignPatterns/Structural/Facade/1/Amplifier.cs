namespace DesignPatterns.Structural.Facade._1;

public class Amplifier
{
    public void On()
    {
        Console.WriteLine("Amplifier is On");
    }

    public void Off()
    {
        Console.WriteLine("Amplifier is Off");
    }

    public void SetVolume(int level)
    {
        Console.WriteLine($"Amplifier volume set to {level}");
    }
}