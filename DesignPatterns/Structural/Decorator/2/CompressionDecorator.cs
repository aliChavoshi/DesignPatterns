namespace DesignPatterns.Structural.Decorator._2;

public class CompressionDecorator(IDataSource dataSource) : IDataSource
{
    public void WriteData(string data)
    {
        var compressData = "compress data";
        Console.WriteLine(compressData);
        dataSource.WriteData(compressData);
    }

    public string ReadData()
    {
        var data = dataSource.ReadData();
        return data;
    }
}