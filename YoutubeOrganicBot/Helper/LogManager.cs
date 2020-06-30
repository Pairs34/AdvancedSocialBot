using Serilog;
using Serilog.Core;

namespace YoutubeOrganicBot.Helper
{
    public static class LogManager
    {
        public static void LogToFile(string Content)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File("log\\log-.txt",rollingInterval:RollingInterval.Hour).CreateLogger();
            Log.Error(Content);
            Log.CloseAndFlush();
        }
    }
}
