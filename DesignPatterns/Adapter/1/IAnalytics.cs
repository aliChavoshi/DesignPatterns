using System.Xml;

namespace DesignPatterns.Adapter._1;

public interface IAnalytics
{
    void Analyze(XmlData xmlData);
}