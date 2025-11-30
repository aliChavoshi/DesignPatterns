namespace DesignPatterns.Singleton;

public sealed class Logger
{
    private static readonly Lazy<Logger> InstanceLazy = new(() => new Logger());
    public static Logger Instance => InstanceLazy.Value; // in this line Logger is created when first accessed

    static Logger()
    {
    }

    private Logger()
    {
        Console.WriteLine("Logger was created with Lazy");
    }

    //this method related to the Instance
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}