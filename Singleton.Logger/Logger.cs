using System;

namespace Singleton.Logger;

public class Logger
{
    // Lazy<T> for thread safe purpose
    private static readonly Lazy<Logger> LazyLogger = new(() => new Logger());

    /// <summary>
    /// Instance
    /// </summary>
    public static Logger Instance => LazyLogger.Value;

    protected Logger()
    {
    }
    
    public static void Log(string message)
    {
        Console.WriteLine($"Message to log: {message}");
    }
}