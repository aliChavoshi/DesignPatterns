namespace DesignPatterns.Structural.Decorator._2;

public class FileDataSource(string filename) : IDataSource
{
    private string _data = "";

    public void WriteData(string data)
    {
        _data = data;
        Console.WriteLine($"write in file {filename}");
    }

    public string ReadData()
    {
        Console.WriteLine($"read from file {filename}");
        return _data;
    }
}