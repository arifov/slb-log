using System;
using Microsoft.Extensions.Configuration;

namespace SLB.Log.Providers.NLog
{
    /// <summary>
    /// NLog log provider implementation
    /// It is not ideal, but could be good basement to start with
    /// </summary>
    public class NLogLogger: ILogger
    {
        private static global::NLog.Logger _logger;

        public NLogLogger(IConfiguration configuration)
        {
            _logger = global::NLog.LogManager.GetCurrentClassLogger();
        }

        public void Dispose()
        {
            global::NLog.LogManager.Shutdown();
            _logger = null;
        }

        public void Write(LogLevel level, string message)
        {
            _logger.Log(level.ToLogEventLevel(), message);
        }

        public void Write(LogLevel level, string message, params object[] propertyValues)
        {
            _logger.Log(level.ToLogEventLevel(), message, propertyValues);
        }

        public void Write(LogLevel level, string message, Exception exception)
        {
            _logger.Log(level.ToLogEventLevel(), exception, message);
        }

        public void Write(LogLevel level, string message, Exception exception, params object[] propertyValues)
        {
            _logger.Log(level.ToLogEventLevel(), exception, message, propertyValues);
        }

        public void Verbose(string message)
        {
            _logger.Trace(message);
        }

        public void Verbose(string message, params object[] propertyValues)
        {
            _logger.Trace(message, propertyValues);
        }

        public void Verbose(string message, Exception exception)
        {
            _logger.Trace(exception, message);
        }

        public void Verbose(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Trace(exception, message, propertyValues);
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
            _logger.Info(message);
        }

        public void Information(string message, params object[] propertyValues)
        {
            _logger.Info(message, propertyValues);
        }

        public void Information(string message, Exception exception)
        {
            _logger.Info(exception, message);
        }

        public void Information(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Info(exception, message, propertyValues);
        }

        public void Warning(string message)
        {
            _logger.Warn(message);
        }

        public void Warning(string message, params object[] propertyValues)
        {
            _logger.Warn(message, propertyValues);
        }

        public void Warning(string message, Exception exception)
        {
            _logger.Warn(exception, message);
        }

        public void Warning(string message, Exception exception, params object[] propertyValues)
        {
            _logger.Warn(exception, message, propertyValues);
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
