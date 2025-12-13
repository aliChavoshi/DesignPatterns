namespace DesignPatterns.Structural.Decorator._2;

public interface IDataSource
{
    void WriteData(string data);

    string ReadData();
}