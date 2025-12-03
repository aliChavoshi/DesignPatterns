namespace DesignPatterns.Creational.Builder._1;

public class Computer
{
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GPU { get; set; }

    public void Display() =>
        Console.WriteLine($"💻 کامپیوتر: CPU={CPU}, RAM={RAM}, Storage={Storage}, GPU={GPU}");
}