using NLog;

public static class LoggingService
{
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    static LoggingService()
    {
        var config = new NLog.Config.LoggingConfiguration();

        // Archivo de destino
        var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "logs/logfile.log" };
        config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);

        LogManager.Configuration = config;
    }

    public static void LogError(Exception ex, string message)
    {
        logger.Error(ex, message);
    }

    public static void LogInfo(string message)
    {
        logger.Info(message);
    }

    public static void Shutdown()
    {
        LogManager.Shutdown();
    }
}
