namespace DesignPatterns.Structural.Decorator._2;

public class EncryptionDecorator(IDataSource source) : IDataSource
{
    public void WriteData(string data)
    {
        string encrypted = $"encrypting {data}]";
        Console.WriteLine("🔒 Encrypting data...");
        source.WriteData(encrypted);
    }

    public string ReadData()
    {
        string data = source.ReadData();
        Console.WriteLine("🔓 Decrypting data...");
        return data.Replace("[encrypted: ", "").Replace("]", "");
    }
}