namespace DesignPatterns.Adapter._1;

public class XmlToJsonAdapter : IAnalytics
{
    private readonly AdvancedAnalytics _advancedAnalytics = new();

    public void Analyze(XmlData xmlData)
    {
        var jsonConverted = new JsonData();
        _advancedAnalytics.Analyze(jsonConverted);
    }
}