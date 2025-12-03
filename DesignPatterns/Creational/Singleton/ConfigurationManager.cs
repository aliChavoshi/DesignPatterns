namespace DesignPatterns.Creational.Singleton;

public sealed class ConfigurationManager
{
    private static ConfigurationManager? Instance { get; set; }
    private static readonly Lock Lock = new();
    public static Dictionary<string, string>? Settings { get; private set; }

    //private constructor to prevent instantiation
    private ConfigurationManager()
    {
        //Add Configuration in the private constructor
        Settings = new Dictionary<string, string>
        {
            { "AppName", "MyApp" },
            { "Version", "1.0" },
            { "Database", "SQL Server" }
        };
    }

    public static ConfigurationManager GetInstance
    {
        get
        {
            if (Instance != null) return Instance;
            lock (Lock) Instance ??= new ConfigurationManager();
            return Instance;
        }
    }
}