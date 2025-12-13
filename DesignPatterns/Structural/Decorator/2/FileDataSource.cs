namespace DesignPatterns.Structural.Decorator._2;

public class FileDataSource(string fileName) : IDataSource
{
    private string _data = "";

    public void WriteData(string data)
    {
        _data = data;
    }

    public string ReadData()
    {
        return fileName + ":" + _data;
    }
}