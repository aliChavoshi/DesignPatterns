namespace DesignPatterns.Structural.Decorator._2;

public class CompressionDecorator(IDataSource source) : IDataSource
{
    public void WriteData(string data)
    {
        string compressed = $"compress {data}]";
        Console.WriteLine("compressing...");
        source.WriteData(compressed);
    }

    public string ReadData()
    {
        string data = source.ReadData();
        Console.WriteLine("opening the compressed data...");
        return data.Replace("[compressed: ", "").Replace("]", "");
    }
}