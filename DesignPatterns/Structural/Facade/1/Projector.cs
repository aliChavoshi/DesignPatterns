namespace DesignPatterns.Structural.Facade._1;

public class Projector
{
    public void On()
    {
        Console.WriteLine("Projector is On");
    }

    public void Off()
    {
        Console.WriteLine("Projector is Off");
    }

    public void WideScreenMode()
    {
        Console.WriteLine("Projector is in WideScreen Mode");
    }
}