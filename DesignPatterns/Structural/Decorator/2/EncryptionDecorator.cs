namespace DesignPatterns.Structural.Decorator._2;

public class EncryptionDecorator(IDataSource dataSource) : IDataSource
{
    public void WriteData(string data)
    {
        var encryptionData = "encrypt data";
        Console.WriteLine(encryptionData);
        dataSource.WriteData(encryptionData);
    }

    public string ReadData()
    {
        var data = dataSource.ReadData();
        return data;
    }
}