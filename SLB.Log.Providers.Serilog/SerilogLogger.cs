using System;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SLB.Log.Providers.Serilog
{
    /// <summary>
    /// Serilog log provider implementation
    /// </summary>
    public class SerilogLogger: ILogger
    {
        public SerilogLogger(IConfiguration configuration)
        {
            global::Serilog.Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public void Dispose()
        {
            global::Serilog.Log.CloseAndFlush();
        }

        public void Write(LogLevel level, string message)
        {
            global::Serilog.Log.Write(level.ToLogEventLevel(), message);
        }

        public void Write(LogLevel level, string message, params object[] propertyValues)
        {
            global::Serilog.Log.Write(level.ToLogEventLevel(), message, propertyValues);
        }

        public void Write(LogLevel level, string message, Exception exception)
        {
            global::Serilog.Log.Write(level.ToLogEventLevel(), exception, message);
        }

        public void Write(LogLevel level, string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Write(level.ToLogEventLevel(), exception, message, propertyValues);
        }

        public void Verbose(string message)
        {
            global::Serilog.Log.Verbose(message);
        }

        public void Verbose(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Verbose(message, propertyValues);
        }

        public void Verbose(string message, Exception exception)
        {
            global::Serilog.Log.Verbose(exception, message);
        }

        public void Verbose(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Verbose(exception, message, propertyValues);
        }

        public void Debug(string message)
        {
            global::Serilog.Log.Debug(message);
        }

        public void Debug(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Debug(message, propertyValues);
        }

        public void Debug(string message, Exception exception)
        {
            global::Serilog.Log.Debug(exception, message);
        }

        public void Debug(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Debug(exception, message, propertyValues);
        }

        public void Information(string message)
        {
            global::Serilog.Log.Information(message);
        }

        public void Information(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Information(message, propertyValues);
        }

        public void Information(string message, Exception exception)
        {
            global::Serilog.Log.Information(exception, message);
        }

        public void Information(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Information(exception, message, propertyValues);
        }

        public void Warning(string message)
        {
            global::Serilog.Log.Warning(message);
        }

        public void Warning(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Warning(message, propertyValues);
        }

        public void Warning(string message, Exception exception)
        {
            global::Serilog.Log.Warning(exception, message);
        }

        public void Warning(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Warning(exception, message, propertyValues);
        }

        public void Error(string message)
        {
            global::Serilog.Log.Error(message);
        }

        public void Error(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Error(message, propertyValues);
        }

        public void Error(string message, Exception exception)
        {
            global::Serilog.Log.Error(exception, message);
        }

        public void Error(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Error(exception, message, propertyValues);
        }

        public void Fatal(string message)
        {
            global::Serilog.Log.Fatal(message);
        }

        public void Fatal(string message, params object[] propertyValues)
        {
            global::Serilog.Log.Fatal(message, propertyValues);
        }

        public void Fatal(string message, Exception exception)
        {
            global::Serilog.Log.Fatal(exception, message);
        }

        public void Fatal(string message, Exception exception, params object[] propertyValues)
        {
            global::Serilog.Log.Fatal(exception, message, propertyValues);
        }
    }
}
