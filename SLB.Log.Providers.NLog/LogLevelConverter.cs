using System;

namespace SLB.Log.Providers.NLog
{
    /// <summary>
    /// Log level converter helper class
    /// </summary>
    internal static class LogLevelConverter
    {
        public static global::NLog.LogLevel ToLogEventLevel(this LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Verbose: return global::NLog.LogLevel.Trace;
                case LogLevel.Debug: return global::NLog.LogLevel.Debug;
                case LogLevel.Information: return global::NLog.LogLevel.Info;
                case LogLevel.Warning: return global::NLog.LogLevel.Warn;
                case LogLevel.Error: return global::NLog.LogLevel.Error;
                case LogLevel.Fatal: return global::NLog.LogLevel.Fatal;
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }
}
