using System;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

namespace SLB.Log
{
    /// <summary>
    /// Serilog log provider implementation
    /// </summary>
    public class LogManager: ILogManager
    {
        private readonly Logger _logger;
        
        public LogManager(IConfiguration configuration)
        {
            _logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger();
        }

        public void Dispose()
        {
            _logger.Dispose();
        }

        public void Write(LogLevel level, string message)
        {
            _logger.Write(level.ToLogEventLevel(), message);
        }

        public void Write(LogLevel level, string message, params object[] propertyValues)
        {
            _logger.Write(level.ToLogEventLevel(), message, propertyValues);
        }

        public void Write(LogLevel level, string message, Exception exception)
        {
            _logger.Write(level.ToLogEventLevel(), exception, message);
        }

        public void Write(LogLevel level, string message, Exception exception, params object[] propertyValues)
        {
            _logger.Write(level.ToLogEventLevel(), exception, message, propertyValues);
        }

        public void Verbose(string message)
        {
            _logger.Verbose(message);
        }

        public void Verbose(string message, params object[] propertyValues)
        {
            _logger.Verbose(message, propertyValues);
        }

        public void Verbose(string message, Exception exception)
        {
            _logger.Verbose(exception, message);
        }

        public void Verbose(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Verbose(exception, message, propertyValues);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, params object[] propertyValues)
        {
            _logger.Debug(message, propertyValues);
        }

        public void Debug(string message, Exception exception)
        {
            _logger.Debug(exception, message);
        }

        public void Debug(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Debug(exception, message, propertyValues);
        }

        public void Information(string message)
        {
            _logger.Information(message);
        }

        public void Information(string message, params object[] propertyValues)
        {
            _logger.Information(message, propertyValues);
        }

        public void Information(string message, Exception exception)
        {
            _logger.Information(exception, message);
        }

        public void Information(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Information(exception, message, propertyValues);
        }

        public void Warning(string message)
        {
            _logger.Warning(message);
        }

        public void Warning(string message, params object[] propertyValues)
        {
            _logger.Warning(message, propertyValues);
        }

        public void Warning(string message, Exception exception)
        {
            _logger.Warning(exception, message);
        }

        public void Warning(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Warning(exception, message, propertyValues);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, params object[] propertyValues)
        {
            _logger.Error(message, propertyValues);
        }

        public void Error(string message, Exception exception)
        {
            _logger.Error(exception, message);
        }

        public void Error(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Error(exception, message, propertyValues);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(string message, params object[] propertyValues)
        {
            _logger.Fatal(message, propertyValues);
        }

        public void Fatal(string message, Exception exception)
        {
            _logger.Fatal(exception, message);
        }

        public void Fatal(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Fatal(exception, message, propertyValues);
        }
    }
}
