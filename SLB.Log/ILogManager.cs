using System;

namespace SLB.Log
{
    /// <summary>
    /// General logger interface.
    /// Mandatory for futher DI, mocking and other log providers implementation (will make migration to let's say NLog easier).
    /// </summary>
    public interface ILogManager: IDisposable
    {
        void Write(LogLevel level, string message);
        void Write(LogLevel level, string message, params object[] propertyValues);
        void Write(LogLevel level, string message, Exception exception);
        void Write(LogLevel level, string message, Exception exception, params object[] propertyValues);
        void Verbose(string message);
        void Verbose(string message, params object[] propertyValues);
        void Verbose(string message, Exception exception);
        void Verbose(string message, Exception exception, params object[] propertyValues);
        void Debug(string message);
        void Debug(string message, params object[] propertyValues);
        void Debug(string message, Exception exception);
        void Debug(string message, Exception exception, params object[] propertyValues);
        void Information(string message);
        void Information(string message, params object[] propertyValues);
        void Information(string message, Exception exception);
        void Information(string message, Exception exception, params object[] propertyValues);
        void Warning(string message);
        void Warning(string message, params object[] propertyValues);
        void Warning(string message, Exception exception);
        void Warning(string message, Exception exception, params object[] propertyValues);
        void Error(string message);
        void Error(string message, params object[] propertyValues);
        void Error(string message, Exception exception);
        void Error(string message, Exception exception, params object[] propertyValues);
        void Fatal(string message);
        void Fatal(string message, params object[] propertyValues);
        void Fatal(string message, Exception exception);
        void Fatal(string message, Exception exception, params object[] propertyValues);
    }
}