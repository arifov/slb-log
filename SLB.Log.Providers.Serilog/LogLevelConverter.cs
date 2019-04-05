using System;
using Serilog.Events;

namespace SLB.Log.Providers.Serilog
{
    /// <summary>
    /// Log level converter helper class
    /// </summary>
    internal static class LogLevelConverter
    {
        public static LogEventLevel ToLogEventLevel(this LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Verbose: return LogEventLevel.Verbose;
                case LogLevel.Debug: return LogEventLevel.Debug;
                case LogLevel.Information: return LogEventLevel.Information;
                case LogLevel.Warning: return LogEventLevel.Warning;
                case LogLevel.Error: return LogEventLevel.Error;
                case LogLevel.Fatal: return LogEventLevel.Fatal;
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }
}
