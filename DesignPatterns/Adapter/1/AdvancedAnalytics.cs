using System.Net.Http.Json;

namespace DesignPatterns.Adapter._1;

public class AdvancedAnalytics
{
    public void Analyze(JsonData json) // فقط JSON می‌پذیرد! ❌
    {
        // تحلیل پیشرفته...
    }
}

public class JsonData
{
}