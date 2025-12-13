using DesignPatterns.Structural.Decorator._1;

namespace DesignPatterns.Structural.Decorator._2;

public class SimpleDataSource : IDataSource
{
    public void WriteData(string data)
    {
        Console.WriteLine("Writing data: " + data);
    }

    public string ReadData()
    {
        Console.WriteLine("Reading data...");
        return "data";
    }
}