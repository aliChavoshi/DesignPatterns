namespace DesignPatterns.Structural.Facade._1;

public class SoundSystem
{
    public void On()
    {
        Console.WriteLine("Sound System is On");
    }

    public void Off()
    {
        Console.WriteLine("Sound System is Off");
    }

    public void SetSurroundSound()
    {
        Console.WriteLine("Surround Sound is Activated");
    }
}