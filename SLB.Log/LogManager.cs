using System;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace SLB.Log
{
    /// <summary>
    /// Serilog log provider implementation
    /// </summary>
    public class LogManager: ILogManager
    {
        public LogManager(IConfiguration configuration)
        {
            Serilog.Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public void Dispose()
        {
            Serilog.Log.CloseAndFlush();
        }

        public void Write(LogLevel level, string message)
        {
            Serilog.Log.Write(level.ToLogEventLevel(), message);
        }

        public void Write(LogLevel level, string message, params object[] propertyValues)
        {
            Serilog.Log.Write(level.ToLogEventLevel(), message, propertyValues);
        }

        public void Write(LogLevel level, string message, Exception exception)
        {
            Serilog.Log.Write(level.ToLogEventLevel(), exception, message);
        }

        public void Write(LogLevel level, string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Write(level.ToLogEventLevel(), exception, message, propertyValues);
        }

        public void Verbose(string message)
        {
            Serilog.Log.Verbose(message);
        }

        public void Verbose(string message, params object[] propertyValues)
        {
            Serilog.Log.Verbose(message, propertyValues);
        }

        public void Verbose(string message, Exception exception)
        {
            Serilog.Log.Verbose(exception, message);
        }

        public void Verbose(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Verbose(exception, message, propertyValues);
        }

        public void Debug(string message)
        {
            Serilog.Log.Debug(message);
        }

        public void Debug(string message, params object[] propertyValues)
        {
            Serilog.Log.Debug(message, propertyValues);
        }

        public void Debug(string message, Exception exception)
        {
            Serilog.Log.Debug(exception, message);
        }

        public void Debug(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Debug(exception, message, propertyValues);
        }

        public void Information(string message)
        {
            Serilog.Log.Information(message);
        }

        public void Information(string message, params object[] propertyValues)
        {
            Serilog.Log.Information(message, propertyValues);
        }

        public void Information(string message, Exception exception)
        {
            Serilog.Log.Information(exception, message);
        }

        public void Information(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Information(exception, message, propertyValues);
        }

        public void Warning(string message)
        {
            Serilog.Log.Warning(message);
        }

        public void Warning(string message, params object[] propertyValues)
        {
            Serilog.Log.Warning(message, propertyValues);
        }

        public void Warning(string message, Exception exception)
        {
            Serilog.Log.Warning(exception, message);
        }

        public void Warning(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Warning(exception, message, propertyValues);
        }

        public void Error(string message)
        {
            Serilog.Log.Error(message);
        }

        public void Error(string message, params object[] propertyValues)
        {
            Serilog.Log.Error(message, propertyValues);
        }

        public void Error(string message, Exception exception)
        {
            Serilog.Log.Error(exception, message);
        }

        public void Error(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Error(exception, message, propertyValues);
        }

        public void Fatal(string message)
        {
            Serilog.Log.Fatal(message);
        }

        public void Fatal(string message, params object[] propertyValues)
        {
            Serilog.Log.Fatal(message, propertyValues);
        }

        public void Fatal(string message, Exception exception)
        {
            Serilog.Log.Fatal(exception, message);
        }

        public void Fatal(string message, Exception exception, params object[] propertyValues)
        {
            Serilog.Log.Fatal(exception, message, propertyValues);
        }
    }
}
